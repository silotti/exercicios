using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {

            // cria o diretório temp2
            Directory.CreateDirectory("C:\\temp2");

            //Copiando um arquivo do diretório C:\temp, para C\temp2:

            string sourceDir = @"c:\temp";
            string backupDir = @"c:\temp2";

            try
            {
                string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

                // Copy picture files.
                foreach (string f in picList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    // Use the Path.Combine method to safely append the file name to the path.
                    // Will overwrite if the destination file already exists.
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }

                // Copy text files.
                foreach (string f in txtList)
                {

                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    try
                    {
                        // Will not overwrite if the destination file already exists.
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }

                    // Catch exception if the file was already copied.
                    catch (IOException copyError)
                    {
                        Console.WriteLine(copyError.Message);
                    }
                }

            }

            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine(dirNotFound.Message);
            }


            Console.Read();
        }
    }
}
