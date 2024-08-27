using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    internal class Program
    {
        static int num1, num2, result, operation;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");

            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");

            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Select operation\n1 = +\n2 = *");

            operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Multiplycation();
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }


        public static void Addition()
        {
            result = num1 + num2;
            Console.WriteLine("Addition is: " + result);
        }


        public static void Multiplycation()
        {
            result = num1 * num2;
            Console.WriteLine("Product is: " + result);
        }
    }
}

