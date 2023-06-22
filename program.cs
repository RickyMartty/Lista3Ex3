using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string p ;
            string m = "m";
            string f = "f";
            do
            {
                Console.Write("Digite o sexo do indivíduo (f ou m):");
                p = Console.ReadLine();

                if (m != p && f != p) Console.WriteLine("Condição invalida.");

            } while (p != m && p != f);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Condição Aceita");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
