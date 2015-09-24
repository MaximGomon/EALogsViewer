using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace EALogsViewer
{
    public static class Helpers
    {
        public static string ToEADate(this DateTime dateTime)
        {

            return dateTime.ToString("dd.MM.yyyy HH:mm:ss");
        }

        public static bool Base64ToImage(string path, string base64String, out string fileWriteError)
        {
            bool success = false;
            fileWriteError = String.Empty;
            //string base64String = tbBase64.Text;
            
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String.Trim());

                File.WriteAllBytes(path, imageBytes);

                success = true;
            }
            catch (Exception ex)
            {
                fileWriteError = ex.ToString();
                success = false;
            }
            //using (MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            //{
            //    ms.Write(imageBytes, 0, imageBytes.Length);
            //    image = Image.FromStream(ms, true);
            //}

            return success;
        }
    }
}
