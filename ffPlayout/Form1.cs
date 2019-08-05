using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace ffPlayout
{
    public partial class Form1 : Form 
    {
        string ffmpeg_exe = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\ffmpeg\\bin\\x64\\ffmpeg.exe";
        string ffprobe_exe = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\ffmpeg\\bin\\x64\\ffprobe.exe";
        public string m_inputFile;
        public int m_ffmpegPID = -1;
        public int m_markIn = 0;
        public string m_colorSpaceFilter = "";
        public string m_colorRangeFilter = "";
        public string m_sourceIsImage = "";

        public Form1(string[] args)
        {
            InitializeComponent();
            fillDevices();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            CheckForIllegalCrossThreadCalls = false;
            textBoxLog.ScrollBars = ScrollBars.Both;
            textBoxLog.WordWrap = false;
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);

            checkParameters(args);
            if (args.Length > 0) {
                m_inputFile = args[0];
                analysis(args[0]);
            }
            populateColorCombos();

        }

        //list all decklink devices, select first
        public void fillDevices() {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffmpeg_exe,
                    Arguments = " -f decklink -list_devices 1 -i dummy",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            string line = "0";
            Dictionary<string, string> d_decklinks = new Dictionary<string, string>();
            
            int count = 0;
            while (!proc.StandardError.EndOfStream)
            {
                line = proc.StandardError.ReadLine();
                if (line.Contains("decklink"))
                {
                    Regex rx = new Regex(@"'(.+?)'", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                    MatchCollection matches = rx.Matches(line);
                    if (matches.Count > 0)
                    {
                        count++;
                        GroupCollection groups = matches[0].Groups;
                        string currentDecklink = groups[1].Value;
                        d_decklinks.Add(currentDecklink, currentDecklink);
                    }
                }
                //parse decklink devices into dropdown
            }
            comboBoxDevices.DataSource = d_decklinks.ToArray();
            comboBoxDevices.DisplayMember = "Value";
            comboBoxDevices.ValueMember = "Key";
            if (d_decklinks.Count == 0) {
                MessageBox.Show("No Decklink Playout card found to be installed in your system, playout will not work");
            }

        }

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //open File
            analysis(files[0]);
        }

        public void populateColorCombos() {

            Dictionary<int, string> d_prim = new Dictionary<int, string>();
            d_prim.Add(1, "BT.709");
            d_prim.Add(8, "BT.2020");
            comboBoxPrimarIn.DataSource = d_prim.ToArray();
            comboBoxPrimarIn.DisplayMember = "Value";
            comboBoxPrimarIn.ValueMember = "Key";
            comboBoxPrimarOut.DataSource = d_prim.ToArray();
            comboBoxPrimarOut.DisplayMember = "Value";
            comboBoxPrimarOut.ValueMember = "Key";
            comboBoxPrimarIn.SelectedIndex = -1;
            comboBoxPrimarOut.SelectedIndex = -1;

            Dictionary<int, string> d_trc = new Dictionary<int, string>();
            d_trc.Add(1, "BT.709");
            d_trc.Add(14, "BT.2020");
            d_trc.Add(18, "arib-std-b67 ");
            comboBoxColorTrcIn.DataSource = d_trc.ToArray();
            comboBoxColorTrcIn.DisplayMember = "Value";
            comboBoxColorTrcIn.ValueMember = "Key";
            comboBoxColorTrcOut.DataSource = d_trc.ToArray();
            comboBoxColorTrcOut.DisplayMember = "Value";
            comboBoxColorTrcOut.ValueMember = "Key";
            comboBoxColorTrcIn.SelectedIndex = -1;
            comboBoxColorTrcOut.SelectedIndex = -1;

            Dictionary<int, string> d_space = new Dictionary<int, string>();
            d_space.Add(0, "RGB");
            d_space.Add(1, "BT.709");
            d_space.Add(8, "bt2020nc");
            d_space.Add(9, "bt2020c");
            d_space.Add(13, "bt2020_ncl");
            d_space.Add(14, "bt2020_cl");
            comboBoxSpaceIn.DataSource = d_space.ToArray();
            comboBoxSpaceIn.DisplayMember = "Value";
            comboBoxSpaceIn.ValueMember = "Key";
            comboBoxSpaceOut.DataSource = d_space.ToArray();
            comboBoxSpaceOut.DisplayMember = "Value";
            comboBoxSpaceOut.ValueMember = "Key";
            comboBoxSpaceIn.SelectedIndex = -1;
            comboBoxSpaceOut.SelectedIndex = -1;

            Dictionary<int, string> d_range = new Dictionary<int, string>();
            d_range.Add(0, "tv");
            d_range.Add(1, "mpeg");
            d_range.Add(2, "pc");
            d_range.Add(3, "jpeg");
            comboBoxRangeIn.DataSource = d_range.ToArray();
            comboBoxRangeIn.DisplayMember = "Value";
            comboBoxRangeIn.ValueMember = "Key";
            comboBoxRangeOut.DataSource = d_range.ToArray();
            comboBoxRangeOut.DisplayMember = "Value";
            comboBoxRangeOut.ValueMember = "Key";
            comboBoxRangeIn.SelectedIndex = -1;
            comboBoxRangeOut.SelectedIndex = -1;
        }

        public void extractPreview(string filepath,string timeseconds = "0") {
            pictureBoxPreviewThumb.SizeMode = PictureBoxSizeMode.StretchImage;
            Helpers.ThumbnailExtractor t = new Helpers.ThumbnailExtractor(ffmpeg_exe, timeseconds);
            if (pictureBoxPreviewThumb.Image != null) {
                pictureBoxPreviewThumb.Image.Dispose();
            }
            pictureBoxPreviewThumb.Image = null;
            pictureBoxPreviewThumb.Image = t.GetThumbnail(filepath);
        }
       

        public void analysis(string filepath) {

            extractPreview(m_inputFile,"0");

            //reset all filters
            comboBoxPrimarIn.SelectedIndex = -1;
            comboBoxColorTrcIn.SelectedIndex = -1;
            checkBoxValidColorAllFilter.Checked = false;

            m_inputFile = filepath;
            labelFilename.Text = Path.GetFileName(filepath);
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = ffprobe_exe,
                    Arguments = "-v error -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 " + " \""+ filepath + "\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            proc.Start();
            string line = "0";
            while (!proc.StandardOutput.EndOfStream)
            {
                line = proc.StandardOutput.ReadLine();
                // do something with line
            }

            labelDuration.Text = line;

            line= line.Replace(".",",");
            try
            {
                trackBarSeek.Maximum = (int)Decimal.Parse(line);
                
            }
            catch (Exception e) {
                labelDuration.Text = "0";

            }
            
        }

        

        private void checkParameters(string[] args) {
            if (args.Length != 0)
            {
                if (!File.Exists(args[0]))
                {
                    MessageBox.Show(args[0] + " is not a File, you must start this program with commandline parameter \"path to file\"");
                }
            }

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            pictureBoxPreviewThumb.Image = null;
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation.
                CustomArguments args = new CustomArguments();
                args.inputFile = m_inputFile;

                backgroundWorker1.RunWorkerAsync(args);

            }
        }

        private void HandleFfmpegOutput(object sender, DataReceivedEventArgs e) {
            if (e.Data == null) {
                return;
            }
            if (e.Data.Contains("time=")) {
                Regex rx = new Regex(@".+?(\d\d:\d\d:\d\d.\d\d).+",RegexOptions.Compiled | RegexOptions.IgnoreCase);
                MatchCollection matches = rx.Matches(e.Data);
                if (matches.Count > 0) {
                    GroupCollection groups = matches[0].Groups;
                    string currentTime = groups[1].Value;
                    labelCurrentTime.Text = currentTime;
                    double seconds = TimeSpan.Parse(currentTime).TotalSeconds;
                    try
                    {
                        setProgress((int)seconds);
                    }
                    catch (Exception exce) { }
                }
            }
            textBoxLog.Text = textBoxLog.Text + e.Data + System.Environment.NewLine;
            textBoxLog.SelectionStart = textBoxLog.TextLength;
            textBoxLog.ScrollToCaret();
        }

        public void setProgress(int seconds) {
            
            trackBarSeek.Value = m_markIn+seconds;
            TimeSpan time = TimeSpan.FromSeconds(m_markIn + seconds);

            //here backslash is must to tell that colon is
            //not the part of format, it just a character that we want in output
            string str = time.ToString(@"hh\:mm\:ss\:fff");
            labelCurrentTime.Text = str;

        }

        private void HandleFfmpegOutputStdout(object sender, DataReceivedEventArgs e)
        {
            // The new data is contained in e.Data
            int stop = 1;
        }

        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            //starts ffmpeg process
            CustomArguments args = (CustomArguments)e.Argument;
            try
            {
                if (!File.Exists(ffmpeg_exe))
                {
                    MessageBox.Show(ffmpeg_exe + " does not exist!");
                }
                string cmd = "";
                if (args.seekTime != null)
                {
                    cmd += " -ss " + args.seekTime;
                }
                cmd += m_sourceIsImage + " -i \"" + args.inputFile +"\" ";
                cmd += m_colorSpaceFilter;
                cmd += m_colorRangeFilter;
                string selectedDecklink = comboBoxDevices.SelectedValue.ToString();
                cmd += " -f decklink -vcodec v210 -c:a pcm_s24le -ar 48000 -ac 8 \""+selectedDecklink+"\"";
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                textBoxFfmpegCmd.Text = "ffmpeg " + cmd;
                proc.StartInfo.FileName = ffmpeg_exe;
                proc.StartInfo.Arguments = cmd;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.ErrorDataReceived += this.HandleFfmpegOutput;
                proc.OutputDataReceived += this.HandleFfmpegOutput;
                proc.Start();
                
                // and start asynchronous read
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();
                
                m_ffmpegPID = proc.Id;
                // wait until it's finished in your background worker thread
                proc.WaitForExit();
                proc.Close();
                e.Cancel = true;
                return;

            }
            catch (Exception err)
            {
                string myerr = err.ToString();
            }
        }

        public void KillProcess(int pid)
        {
            Process[] process = Process.GetProcesses();

            foreach (Process prs in process)
            {
                if (prs.Id == pid)
                {
                    prs.Kill();

                    break;
                }
            }
        }

        private void trackBarSeek_MouseUp(object sender, MouseEventArgs e)
        {
            m_markIn = trackBarSeek.Value;

            //kill running ffmpeg process and restart new
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerCompleted += backgroundWorker1_seekAfterComplete;
                if (m_ffmpegPID > -1)
                {
                    KillProcess(m_ffmpegPID);
                }
            }
            else {
                backgroundWorker1_seekAfterComplete(null,null);
            }

        }

        private void backgroundWorker1_seekAfterComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            extractPreview(m_inputFile, trackBarSeek.Value.ToString());
            //seek to time that user chose on slider
            backgroundWorker1.RunWorkerCompleted -= backgroundWorker1_seekAfterComplete;
            CustomArguments args = new CustomArguments();
            args.inputFile = m_inputFile;
            args.seekTime = trackBarSeek.Value.ToString();
            backgroundWorker1.RunWorkerAsync(args);
        }

      

        private void buttonStop_Click(object sender, EventArgs e)
        {
            m_markIn = trackBarSeek.Value;
            if (m_ffmpegPID > -1)
            {
                KillProcess(m_ffmpegPID);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_ffmpegPID > -1)
            {
                KillProcess(m_ffmpegPID);
            }
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            // Display the openFile dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                m_inputFile = openFileDialog1.FileName;
                try
                {
                    // Output the requested file in richTextBox1.

                    analysis(m_inputFile);

                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                    + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
               
                }
                Invalidate();

            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }

        }

    
        private void checkValidColorFilter(object sender, EventArgs e) {
            //checks if all color stuff is set
            if (comboBoxRangeIn.SelectedIndex != -1 && comboBoxRangeOut.SelectedIndex != -1 && comboBoxPrimarIn.SelectedIndex != -1 && comboBoxColorTrcIn.SelectedIndex != -1 && comboBoxSpaceIn.SelectedIndex != -1 && comboBoxPrimarOut.SelectedIndex != -1 && comboBoxColorTrcOut.SelectedIndex != -1 && comboBoxSpaceOut.SelectedIndex != -1) {
                m_colorSpaceFilter = "";
                checkBoxValidColorAllFilter.Checked = true;
                //m_colorAllFilter = ",colorspace=iall="+comboBoxPrimarIn.SelectedIndex+":all="+comboBoxColorTrcIn.SelectedIndex;
                m_colorSpaceFilter =  " -vf colorspace=iprimaries=" + comboBoxPrimarIn.SelectedValue +
                             ":primaries=" + comboBoxPrimarOut.SelectedValue +
                                  ":itrc=" + comboBoxColorTrcIn.SelectedValue +
                                   ":trc=" + comboBoxColorTrcOut.SelectedValue +
                                ":ispace=" + comboBoxSpaceIn.SelectedValue +
                                ":space=" + comboBoxSpaceOut.SelectedValue +
                                ":irange=" + comboBoxRangeIn.SelectedValue +
                                ":range=" + comboBoxRangeOut.SelectedValue;
                // m_colorAllFilter = ",colorspace=iall=" + comboBoxPrimarIn.SelectedIndex + ":all=" + comboBoxColorTrcIn.SelectedIndex;
                return ;
            }
            checkBoxValidColorAllFilter.Checked = false;
            m_colorSpaceFilter = "";
            return ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                m_sourceIsImage = " -loop 1 -r 50 ";
            }
            else {
                m_sourceIsImage = "";
            }
        }
    }
}

class Player {


}

class CustomArguments {
    public string inputFile = null;
    public string seekTime = null;

    public CustomArguments() {

    }

}