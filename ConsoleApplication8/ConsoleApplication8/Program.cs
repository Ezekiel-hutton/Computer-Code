using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Int. Base:10 ");
            int a = 10;
            Console.WriteLine();
            Console.WriteLine("Int. Height:12");
            int b = 12;
            Console.WriteLine();
            double c = Math.Sqrt((a * a) + (b * b));
            c = Math.Round(c, 3);

            Console.WriteLine("Hypotenuse = " + c);
                 //Console.ReadKey();
        }
    }
}
