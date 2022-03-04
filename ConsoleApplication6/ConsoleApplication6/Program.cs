using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int Base = 10;
            int Height = 12;
            int Basesq = 10 * 12;
            Double s = Math.Sqrt(Basesq);
            Console.WriteLine(s);
            //Console.ReadKey();
            int a = 8, b = 5, c;
            c = a + b;
            Console.WriteLine(Base = 10);
            Console.WriteLine(a + " * " + b + " = " + c);
            c = a / b;
            Console.WriteLine(a + " / " + b + " = " + c);
            c = a % b;
            Console.WriteLine(a + "%" + b + " = " + c);
            c = a + b * a - b % a;
            Console.WriteLine(a + " + " + b + " * " + a + " -" + b + " % " + a + " = " + c);
        }
    }
}
