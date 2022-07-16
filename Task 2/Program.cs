using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Dif(double a, double b)
        {
            return a - b;
        }

        static double Mul(double a, double b)
        {
            return a * b;
        }

        static double Div(double a, double b)
        {
            return a / b;
        }


        static void Main(string[] args)
        {
            double operand1;
            double operand2;

            Console.WriteLine("Choose first value");
            operand1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose second value");
            operand2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, Add(operand1, operand2));
            Console.WriteLine("{0} - {1} = {2}", operand1, operand2, Dif(operand1, operand2));
            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, Mul(operand1, operand2));

            if (operand2 != 0)
            {
                Console.WriteLine("{0} / {1} = {2}", operand1, operand2, Div(operand1, operand2));
            }
            else
            {
                Console.WriteLine("You can't divide by zero");
            }
            Console.ReadLine();


            
        }
    }
}
