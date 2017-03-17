using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchXLinearSearch
{
    class Program
    {
        static int number;
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o número voce quer procurar?");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Search.Linear(number, new int[5] { 1, 3, 4, 8, 50 });
                Search.Binary(number, new int[19] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 18, 19, 20 });

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Entre um valor válido");
            }

            Console.ReadKey();
        }
    }
}
