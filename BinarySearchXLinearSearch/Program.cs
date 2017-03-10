using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchXLinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Search.Linear(7, new int[5] { 1, 3, 4, 8, 50 });
            Search.Binary(1, new int[20] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20} );
            Console.ReadKey();
        }
    }
}
