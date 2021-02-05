using System;
using System.Collections.Generic;

namespace EvenlyDistribute
{
    class Program
    {
        public static void Distribute(int numOfItems, int numOfBoxes)
        {
            int itemsPerBox = numOfItems / numOfBoxes;       // Number of items to be distributed in each box
            int remainder = numOfItems % numOfBoxes;         // Remainder of items after distribution 
            int[] arr = new int[numOfBoxes];                 // Initializing integer array 

            for (int i = 1; i <= numOfBoxes; i++)            // Iterating over array to add items to boxes
            {
                int extra = (i <= remainder) ? 1 : 0;        // Checking distribution of remainder
                arr[i - 1] = itemsPerBox + extra;            // Distributing items through boxes
            }

            Array.Reverse(arr);
            Console.WriteLine($"[{string.Join(" ", arr)}]"); // Reversing and joining array for desired output
        }

        static void Main(string[] args)
        {
            Distribute(22, 4);
        }
    }
}
