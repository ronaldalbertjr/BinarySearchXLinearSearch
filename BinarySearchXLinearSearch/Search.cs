using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchXLinearSearch
{
    static class Search
    {
        public static int Linear(int numberToFind, int[] arrayOfNumbers)
        {
            Console.WriteLine("Linear Search");
            Console.ReadKey();
            int positionFound = 0;
            int lastDistance = arrayOfNumbers[arrayOfNumbers.Length - 1] - arrayOfNumbers[0];
            for(int i = 0; i < arrayOfNumbers.Length; i++)
            {
                if (Math.Abs(arrayOfNumbers[i] - numberToFind) < lastDistance)
                {
                    lastDistance = Math.Abs(arrayOfNumbers[i] - numberToFind);
                    positionFound = i;
                }
                Console.WriteLine("The element in position " + i + " is " + arrayOfNumbers[i]);
                Console.ReadKey();
            }
            Console.WriteLine("The closest number to " + numberToFind + " is " + arrayOfNumbers[positionFound] + " in position " + positionFound);
            return positionFound;
        }

        public static int Binary(int numberToFind, int[] arrayOfNumbers)
        {
            Console.WriteLine("Binary Search");
            Console.ReadKey();
            int positionFound = (int)Math.Floor((double)arrayOfNumbers.Length / 2);
            int maxRange = arrayOfNumbers.Length - 1;
            int minRange = 0;
            while (minRange != maxRange)
            {
                positionFound = (maxRange + minRange) / 2;
                Console.WriteLine("The number in position " + positionFound + " is " + arrayOfNumbers[positionFound]);
                Console.ReadKey();
                if (arrayOfNumbers[positionFound] > numberToFind)
                {
                    maxRange = positionFound;
                }
                else if (arrayOfNumbers[positionFound] < numberToFind)
                {
                    minRange = positionFound;
                }
                else
                {
                    Console.WriteLine("The closest number to " + numberToFind + " is " + arrayOfNumbers[positionFound] + " in position " + positionFound);
                    break;
                }
            }
            return positionFound;
        }

    }
}
