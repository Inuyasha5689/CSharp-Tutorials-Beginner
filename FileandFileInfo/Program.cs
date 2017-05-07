using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileandFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\someefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path))
            {
                
            }
            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...", true);
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                
            }
//            fileInfo.Read doesn't exist.
        }
    }
}
