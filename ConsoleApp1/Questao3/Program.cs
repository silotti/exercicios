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

            //Cria o diretório temp2
            Directory.CreateDirectory("C:\\temp2");

            //Copiando um arquivo do diretório C:\temp, para C\temp2:
            string sourceDir = @"c:\temp";
            string backupDir = @"c:\temp2";

            try
            {
                string[] picList = Directory.GetFiles(sourceDir, "*.jpg");
                string[] txtList = Directory.GetFiles(sourceDir, "*.txt");

                // Copia arquivos de imagem
                foreach (string f in picList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    // Usa o metodo Path.Combine para anexar com segurança o nome do caminho ao arquivo
                    // Sobrescreve se o arquivo de destino já existir
                    File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName), true);
                }

                // Copia arquivos de texto
                foreach (string f in txtList)
                {
                    // Remove path from the file name.
                    string fName = f.Substring(sourceDir.Length + 1);

                    //excessão, mostra se já existir os arquivos de texto
                    try
                    {
                        // não irá sobreescrever no destino de já existir os arquivos
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(backupDir, fName));
                    }

                    // Catch exception se o arquivo já foi copiado
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
