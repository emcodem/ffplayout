namespace ffPlayout
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDuration = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarSeek = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelFilename = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRangeOut = new System.Windows.Forms.ComboBox();
            this.checkBoxValidColorAllFilter = new System.Windows.Forms.CheckBox();
            this.comboBoxRangeIn = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSpaceOut = new System.Windows.Forms.ComboBox();
            this.comboBoxSpaceIn = new System.Windows.Forms.ComboBox();
            this.comboBoxColorTrcOut = new System.Windows.Forms.ComboBox();
            this.comboBoxPrimarOut = new System.Windows.Forms.ComboBox();
            this.comboBoxPrimarIn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxColorTrcIn = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxFfmpegCmd = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBoxPreviewThumb = new System.Windows.Forms.PictureBox();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(81, 16);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(13, 13);
            this.labelDuration.TabIndex = 0;
            this.labelDuration.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Duration";
            // 
            // trackBarSeek
            // 
            this.trackBarSeek.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSeek.Location = new System.Drawing.Point(12, 502);
            this.trackBarSeek.Name = "trackBarSeek";
            this.trackBarSeek.Size = new System.Drawing.Size(709, 45);
            this.trackBarSeek.TabIndex = 2;
            this.trackBarSeek.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarSeek_MouseUp);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.Location = new System.Drawing.Point(16, 473);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 3;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.Location = new System.Drawing.Point(112, 473);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 4;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.Location = new System.Drawing.Point(264, 171);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(457, 325);
            this.textBoxLog.TabIndex = 5;
            this.textBoxLog.Text = "Log Output";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Time:";
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Location = new System.Drawing.Point(91, 445);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(13, 13);
            this.labelCurrentTime.TabIndex = 7;
            this.labelCurrentTime.Text = "0";
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(13, 13);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseFile.TabIndex = 8;
            this.buttonBrowseFile.Text = "Browse";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelFilename
            // 
            this.labelFilename.AutoSize = true;
            this.labelFilename.Location = new System.Drawing.Point(16, 39);
            this.labelFilename.MaximumSize = new System.Drawing.Size(200, 300);
            this.labelFilename.Name = "labelFilename";
            this.labelFilename.Size = new System.Drawing.Size(49, 13);
            this.labelFilename.TabIndex = 9;
            this.labelFilename.Text = "Filename";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxRangeOut);
            this.groupBox1.Controls.Add(this.checkBoxValidColorAllFilter);
            this.groupBox1.Controls.Add(this.comboBoxRangeIn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxSpaceOut);
            this.groupBox1.Controls.Add(this.comboBoxSpaceIn);
            this.groupBox1.Controls.Add(this.comboBoxColorTrcOut);
            this.groupBox1.Controls.Add(this.comboBoxPrimarOut);
            this.groupBox1.Controls.Add(this.comboBoxPrimarIn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxColorTrcIn);
            this.groupBox1.Location = new System.Drawing.Point(12, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 191);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Range";
            // 
            // comboBoxRangeOut
            // 
            this.comboBoxRangeOut.FormattingEnabled = true;
            this.comboBoxRangeOut.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxRangeOut.Location = new System.Drawing.Point(177, 103);
            this.comboBoxRangeOut.Name = "comboBoxRangeOut";
            this.comboBoxRangeOut.Size = new System.Drawing.Size(62, 21);
            this.comboBoxRangeOut.TabIndex = 12;
            this.comboBoxRangeOut.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // checkBoxValidColorAllFilter
            // 
            this.checkBoxValidColorAllFilter.AutoSize = true;
            this.checkBoxValidColorAllFilter.Enabled = false;
            this.checkBoxValidColorAllFilter.Location = new System.Drawing.Point(153, 130);
            this.checkBoxValidColorAllFilter.Name = "checkBoxValidColorAllFilter";
            this.checkBoxValidColorAllFilter.Size = new System.Drawing.Size(48, 17);
            this.checkBoxValidColorAllFilter.TabIndex = 5;
            this.checkBoxValidColorAllFilter.Text = "valid";
            this.checkBoxValidColorAllFilter.UseVisualStyleBackColor = true;
            // 
            // comboBoxRangeIn
            // 
            this.comboBoxRangeIn.FormattingEnabled = true;
            this.comboBoxRangeIn.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxRangeIn.Location = new System.Drawing.Point(107, 103);
            this.comboBoxRangeIn.Name = "comboBoxRangeIn";
            this.comboBoxRangeIn.Size = new System.Drawing.Size(64, 21);
            this.comboBoxRangeIn.TabIndex = 11;
            this.comboBoxRangeIn.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Colorspace";
            // 
            // comboBoxSpaceOut
            // 
            this.comboBoxSpaceOut.FormattingEnabled = true;
            this.comboBoxSpaceOut.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxSpaceOut.Location = new System.Drawing.Point(177, 76);
            this.comboBoxSpaceOut.Name = "comboBoxSpaceOut";
            this.comboBoxSpaceOut.Size = new System.Drawing.Size(62, 21);
            this.comboBoxSpaceOut.TabIndex = 9;
            this.comboBoxSpaceOut.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // comboBoxSpaceIn
            // 
            this.comboBoxSpaceIn.FormattingEnabled = true;
            this.comboBoxSpaceIn.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxSpaceIn.Location = new System.Drawing.Point(107, 76);
            this.comboBoxSpaceIn.Name = "comboBoxSpaceIn";
            this.comboBoxSpaceIn.Size = new System.Drawing.Size(64, 21);
            this.comboBoxSpaceIn.TabIndex = 8;
            this.comboBoxSpaceIn.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // comboBoxColorTrcOut
            // 
            this.comboBoxColorTrcOut.FormattingEnabled = true;
            this.comboBoxColorTrcOut.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxColorTrcOut.Location = new System.Drawing.Point(177, 49);
            this.comboBoxColorTrcOut.Name = "comboBoxColorTrcOut";
            this.comboBoxColorTrcOut.Size = new System.Drawing.Size(62, 21);
            this.comboBoxColorTrcOut.TabIndex = 7;
            this.comboBoxColorTrcOut.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // comboBoxPrimarOut
            // 
            this.comboBoxPrimarOut.FormattingEnabled = true;
            this.comboBoxPrimarOut.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxPrimarOut.Location = new System.Drawing.Point(177, 22);
            this.comboBoxPrimarOut.Name = "comboBoxPrimarOut";
            this.comboBoxPrimarOut.Size = new System.Drawing.Size(62, 21);
            this.comboBoxPrimarOut.TabIndex = 6;
            this.comboBoxPrimarOut.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // comboBoxPrimarIn
            // 
            this.comboBoxPrimarIn.FormattingEnabled = true;
            this.comboBoxPrimarIn.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxPrimarIn.Location = new System.Drawing.Point(107, 22);
            this.comboBoxPrimarIn.Name = "comboBoxPrimarIn";
            this.comboBoxPrimarIn.Size = new System.Drawing.Size(64, 21);
            this.comboBoxPrimarIn.TabIndex = 4;
            this.comboBoxPrimarIn.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Transcer Char";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primaries";
            // 
            // comboBoxColorTrcIn
            // 
            this.comboBoxColorTrcIn.FormattingEnabled = true;
            this.comboBoxColorTrcIn.Items.AddRange(new object[] {
            "bt470m",
            "bt470bg",
            "bt601-6-525",
            "bt601-6-625",
            "bt709",
            "smpte170m",
            "smpte240m",
            "bt2020"});
            this.comboBoxColorTrcIn.Location = new System.Drawing.Point(107, 49);
            this.comboBoxColorTrcIn.Name = "comboBoxColorTrcIn";
            this.comboBoxColorTrcIn.Size = new System.Drawing.Size(64, 21);
            this.comboBoxColorTrcIn.TabIndex = 1;
            this.comboBoxColorTrcIn.SelectedIndexChanged += new System.EventHandler(this.checkValidColorFilter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelDuration);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Analysis";
            // 
            // textBoxFfmpegCmd
            // 
            this.textBoxFfmpegCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFfmpegCmd.Location = new System.Drawing.Point(264, 145);
            this.textBoxFfmpegCmd.Name = "textBoxFfmpegCmd";
            this.textBoxFfmpegCmd.Size = new System.Drawing.Size(457, 20);
            this.textBoxFfmpegCmd.TabIndex = 12;
            this.textBoxFfmpegCmd.Text = "ffmpeg command";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(96, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Source is Image";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBoxPreviewThumb
            // 
            this.pictureBoxPreviewThumb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreviewThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreviewThumb.Location = new System.Drawing.Point(517, 12);
            this.pictureBoxPreviewThumb.Name = "pictureBoxPreviewThumb";
            this.pictureBoxPreviewThumb.Size = new System.Drawing.Size(204, 116);
            this.pictureBoxPreviewThumb.TabIndex = 14;
            this.pictureBoxPreviewThumb.TabStop = false;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.Location = new System.Drawing.Point(390, 107);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDevices.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Device";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 559);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxDevices);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxFfmpegCmd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelFilename);
            this.Controls.Add(this.buttonBrowseFile);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.trackBarSeek);
            this.Controls.Add(this.pictureBoxPreviewThumb);
            this.Name = "Form1";
            this.Text = "FFPlayout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSeek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewThumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarSeek;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label labelFilename;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPrimarIn;
        private System.Windows.Forms.ComboBox comboBoxColorTrcIn;
        private System.Windows.Forms.CheckBox checkBoxValidColorAllFilter;
        private System.Windows.Forms.ComboBox comboBoxPrimarOut;
        private System.Windows.Forms.ComboBox comboBoxSpaceOut;
        private System.Windows.Forms.ComboBox comboBoxSpaceIn;
        private System.Windows.Forms.ComboBox comboBoxColorTrcOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRangeOut;
        private System.Windows.Forms.ComboBox comboBoxRangeIn;
        private System.Windows.Forms.TextBox textBoxFfmpegCmd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBoxPreviewThumb;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Label label7;
    }
}

