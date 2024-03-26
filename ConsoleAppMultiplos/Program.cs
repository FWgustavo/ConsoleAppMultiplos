using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMultiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o número que deseja saber: ");
            int vezes = int.Parse(Console.ReadLine());

            int cont = vezes;
            while (cont <= 100) 
            {
                Console.WriteLine(cont);
                 
                cont += vezes;
            }
            Console.ReadKey();
        }
    }
}
