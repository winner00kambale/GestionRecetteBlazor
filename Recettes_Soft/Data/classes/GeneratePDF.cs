using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Recettes_Soft.Data.classes
{
    public class GeneratePDF
    {
        private string url { get; set; }
        public GeneratePDF(string url)
        {
            this.url = url;
        }
        public byte[] GetPdf()
        {
            var switches = $"-q {url} -";
            string rotativaPath = Path.Combine(Directory.GetCurrentDirectory(), "Rotativa", "wkhtmltopdf.exe");
            using (var proc = new Process())
            {
                try
                {
                    proc.StartInfo = new ProcessStartInfo
                    {
                        FileName = rotativaPath,
                        Arguments = switches,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        CreateNoWindow = true
                    };
                    proc.Start();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                using(var ms=new MemoryStream())
                {
                    proc.StandardOutput.BaseStream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }
    }
}
