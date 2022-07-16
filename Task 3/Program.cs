using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static double Converter(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            double amount;
            double rate;

            Console.WriteLine("Enter the amount");
            amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the rate");
            rate = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your monetary amount is {0}. Rate is {1}. Your monetary amount after converting {2}", amount, rate, Converter(amount, rate));
            Console.ReadLine();
        }
    }
}
