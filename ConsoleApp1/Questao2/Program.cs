using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class Program
    {
        //mostra todos arquivos .txt da pasta Temp em c:\
        static void Main(string[] args)
        {
            string[] arquivos = Directory.GetFiles("C:\\Temp", "*.txt", SearchOption.AllDirectories);

            Console.WriteLine("Arquivos:");
            foreach (string arq in arquivos)
            {
                Console.WriteLine(arq);
            }
            Console.Read();
        }
    }
}
