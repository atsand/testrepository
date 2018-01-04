using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplaySalesTax(100);
        }

        private static void DisplaySalesTax(double salesAmount)
        {
            const double RATE = 0.07;
            double tax = RATE * salesAmount;
            Console.WriteLine("The tax on {0} is {1}.", salesAmount.ToString("C"), tax.ToString("C"));
        }

    }
}
