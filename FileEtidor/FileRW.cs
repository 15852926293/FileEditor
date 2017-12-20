using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEtidor
{
    class FileRW
    {
        public static string fileReader(string filePath)
        {
            string fileStram = "";
            StreamReader sr = new StreamReader(filePath, Encoding.Default);
            String line;
            while ((line = sr.ReadLine()) != null)
            {
                fileStram += line + "\n";
            }
            sr.Close();
            return fileStram;
        }

        public static void fileWriter(string filePath, string fileStream)
        {
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(fileStream.Replace("\n","\r\n"));
            sw.Close();
            fs.Close();
        }
    }
}
