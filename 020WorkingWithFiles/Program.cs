using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if you have small number of operations (get attribute of file) , we use static methods - file, directory*/
            /* if you have huge number of operations we use instance methods - fileinfo, directoryinfo*/
            var path = @"C:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", "c:\temp\myfile2.jpg",true); /*true is overwrite option*/
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("File is exists");
            }
            var content = File.ReadAllText(path);
            
            /*With fileinfo... if you have large number of operations use this*/
            var fileinfo = new FileInfo(path);
            fileinfo.CopyTo("...");
            fileinfo.Delete();
            if (fileinfo.Exists)
            {
                Console.WriteLine("File is exists");
            }




            /*Working With Directory*/
            Directory.CreateDirectory(@"C:\temp\folder");
            var files = Directory.GetFiles(@"C:\projects", "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\projects", "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");



            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            var path2 = @"C:\somefile.jpg";

            var fileType = Path.GetExtension(path2); /* .jpg */
            var fileName = Path.GetFileName(path2); /* somefile.jpg */
            var fileNameWithoutEx = Path.GetFileNameWithoutExtension(path2); /* somefile */
            var directoryName = Path.GetDirectoryName(path2); /* c:\ */
        }
    }
}
