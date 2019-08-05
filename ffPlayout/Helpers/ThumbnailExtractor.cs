using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Runtime;
using System.Windows.Forms;
namespace ffPlayout.Helpers
{
    class ThumbnailExtractor
    {
        public static string ffmpeg = "";
        public static string time = "0";
        public ThumbnailExtractor(string ffmpeglocation,string timeSeconds="0") {
            time = timeSeconds;
            ffmpeg = ffmpeglocation;
        }

        public  Bitmap GetThumbnail(string video)
        {
            if (File.Exists(Environment.ExpandEnvironmentVariables("\"%temp%\\temp.bmp\""))) {
                try
                {
                    File.Delete(Environment.ExpandEnvironmentVariables("\"%temp%\\temp.bmp\""));
                }
                catch (Exception e) { }
            }
            var cmd = "\"" + ffmpeg + "\"  -ss "+ time + "  -i " + '"' + video + '"' + " -vframes 1 -an -y -s 512x240 " + "\"%temp%\\temp.bmp\"";
            cmd = Environment.ExpandEnvironmentVariables(cmd);
            cmd += " 2>&1 > c:\\temp\\out.log 2>&1";
            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C \"" + cmd + "\""
            };

            var process = new Process
            {
                StartInfo = startInfo
            };

            process.Start();
            process.WaitForExit(5000);
            if (process.ExitCode == 0)
            {
                return LoadImage(Environment.ExpandEnvironmentVariables("%temp%\\temp.bmp"));
            }
            else {
                
            }
            return null;
            
        }

        static Bitmap LoadImage(string path)
        {
            var ms = new MemoryStream(File.ReadAllBytes(path));
            return (Bitmap)Image.FromStream(ms);
        }

    }
}
