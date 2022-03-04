using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
       double a = 10, b = 12, c;
           double c = a + b;
           Console.WriteLine("int. Base = 10");
           Console.WriteLine("");
           Console.WriteLine("int. Height = 12");
           Console.WriteLine("");
           int c = Math.Sqrt((a * a) + (b * b));
          
           Console.WriteLine("The hypotenuse is: " + c);

            //Console.ReadKey();
        }
    }
}