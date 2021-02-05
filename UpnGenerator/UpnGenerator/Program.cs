using System;

namespace UpnGenerator
{
    class Program
    {
        public static string UPNGenerator(string companyCode, int productCode)
        {
            productCode += 1;                                                           // Increasing productCode by 1

            string tempCode = string.Format("{0}{1}", companyCode, productCode);        // Initializing temporary code to calculate check digit

            int evenSum = 0;                                                            // Initializing variables
            int oddSum = 0;
            int digit;
            int checkDigit;

            for (int i = 1; i < tempCode.Length + 1; i++)                               // Iterating over temporary code to extract even and odd digit sums
            {
                digit = Convert.ToInt32(tempCode.Substring(i - 1, 1));                  // Extracting current digit 

                if (i % 2 == 0)
                    evenSum += digit;
                else
                    oddSum += digit;
            }

            checkDigit = (((oddSum * 3) + evenSum) % 10 == 0) ? 0 : (10 - (((oddSum * 3) + evenSum) % 10)); // Calculating checkDigit

            string upnCode = string.Format("{0}{1}{2}", companyCode, productCode, checkDigit);

            return upnCode;
        }

        static void Main(string[] args)
        {
            const string companyCode = "036000";

            int productCode = 24144;

            Console.WriteLine(UPNGenerator(companyCode, productCode));
        }
    }
}
