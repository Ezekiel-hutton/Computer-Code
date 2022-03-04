using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        { double a, b;
            int input;
            Console.WriteLine("Enter First Number");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Choose An Arithmetic Operation to perform\n-------------------------------------------- \n\t1.Addition\n\t2.Multiplication\n\t3.Division\n\t4.Subtraction\n\t5.Modolus");
            input = Convert.ToInt16(Console.ReadLine());
            switch(input)
            {
                case 1: Console.WriteLine(a + " + " + b + " = "+ (a + b));
                    break;

                case 2: Console.WriteLine(a + " * " + b + " = "+(a * b));
                    break;

                case 3: Console.WriteLine(a + " / " + b + " = "+(a / b));
                    break;

                case 4: Console.WriteLine(a + " - " + b + " = "+(a - b));
                    break;

                case 5: Console.WriteLine(a + " % " + b + " = "+(a % b));
                    break;

                default: Console.WriteLine("Wrong option try again");
                    break;
            }
            Console.ReadKey();
        }
    }

}