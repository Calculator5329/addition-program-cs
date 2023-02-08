using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args) 
        {   
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter an operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + " " + op + " " + num2 + " = " + calc(num1, num2, op));

            Console.ReadLine();
        }

        static double calc(double num1, double num2, string op) {
            double res = 0;

            if(op == "+") {
                res = num1 + num2;
            }
            else if(op == "-") {
                res = num1 - num2;
            }   
            else if(op == "*") {
                res = num1 * num2;
            }
            else if(op == "/") {
                res = num1 / num2;
            }

            return res;
        }

    }
}