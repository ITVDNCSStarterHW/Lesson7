using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void CheckedValue(double a)
        {
            bool simple = true;


            //Checking a number for whether it greater or less than zero
            if (a > 0)
            {
                Console.WriteLine("Value is greater than 0");
            }
            else if (a == 0)
            {
                Console.WriteLine("Value is equel 0");
            }
            else
            {
                Console.WriteLine("Value is less than 0");
            }

            //Checking a number for whether it is simple or not
            for (int counter = 2; a / 2 >= counter; counter++)
            {
                if (a % counter == 0)
                {
                    simple = false;
                    break;
                }
            }
            if (simple == true)
            {
                Console.WriteLine("{0} is simple", a);
            }
            else
            {
                Console.WriteLine("{0} isn't simple", a);
            }

            //Checking a number for whether it divide by 2, 5, 3, 6, 9
            if (a % 2 ==0 || a % 5 == 0 || a % 3 == 0 || a % 6 == 0 || a % 9 == 0)
            {
                Console.WriteLine("{0} is divided by 2 or 5 or 3 or 6 or 9", a);
            }
            else
            {
                Console.WriteLine("{0} isn't divided by 2 or 5 or 3 or 6 or 9", a);
            }
        }

        static void Main(string[] args)
        {
            double value;
            Console.WriteLine("Choose value");
            value = Convert.ToDouble(Console.ReadLine());

            CheckedValue(value);
            CheckedValue(15);
            CheckedValue(19);
            CheckedValue(7);
            CheckedValue(100);

            Console.ReadLine();
        }
    }
}
