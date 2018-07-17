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

            // cria o diretório Temp2
            Directory.CreateDirectory("C:\\Temp2");

            //Copiando um arquivo do diretório C:, para D:
            File.Copy("C:\\Temp\\imagem.jpg", "C:\\Temp2\\imagem.jpg");

            Console.Read();
        }
    }
}
