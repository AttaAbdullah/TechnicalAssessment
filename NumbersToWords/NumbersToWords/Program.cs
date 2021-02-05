using System;

namespace NumbersToWords
{
    class Program
    {
        static void NumbersToWords(int number)
        {
            String[] units = { "Zero", "One", "Two", "Three",                           // Initializing word map
            "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
            "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
            "Seventeen", "Eighteen", "Nineteen" };

            String[] tens = {"", "", "Twenty", "Thirty", "Forty",
             "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            while (number < 0 || number > 999)                                          // Checking if input is within range 
            {
                Console.WriteLine("Error: Number out of range.\nEnter a number between 0 and 999.");
                number = Convert.ToInt32(Console.ReadLine());
            }

            if (number < 20)                                                            // Checking value of number to return approriate word elements 
                Console.WriteLine(units[number]);

            else if (number < 100 && number >= 20)
            {
                if (number % 10 == 0)
                    Console.WriteLine(tens[number / 10]);

                else
                    Console.WriteLine($"{tens[number / 10]} {units[number % 10]}");
            }

            else if (number > 99)
            {
                if (number % 100 == 0)
                    Console.WriteLine($"{units[number / 100]} hundred");

                else if (number % 100 != 0 && number % 10 == 0)
                    Console.WriteLine($"{units[number / 100]} hundred {tens[(number % 100) / 10].ToLower()}");

                else if (number % 100 != 0 && number % 10 != 0 && number % 100 < 20)
                    Console.WriteLine($"{units[number / 100]} hundred and {units[number % 100].ToLower()}");

                else
                    Console.WriteLine($"{units[number / 100]} hundred {tens[(number % 100) / 10].ToLower()} {units[number % 10].ToLower()}");
            }
        }

        static void Main(string[] args)
        {

            int number = 183;

            NumbersToWords(number);
        }
    }
}
