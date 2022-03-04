using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark, max = 0, min = 1000; sum = 0;
            double avg;
            for (int a = 1; a < 8; a++)
            {
                Console.WriteLine("Enter Mark -" + a + " : ");
                mark = Convert.ToInt16(Console.ReadLine());
                //Cummulative Sum
                sum = sum+ mark; // Sum+=mark;
                //Highest Mark
                if (mark < min)
                {
                    max = mark;
                }
                //Lowest Mark
                if (mark < min)
                {
                    min = mark;
                }
            }
            avg = sum / 7; //Average
            //Display Answers
            Console.WriteLine("\nTotal Score - " + sum +
                "\nHighest Score - " + max + "\nLowest Score - " + min +
                "\average Score - " + avg + "\n");
        }
    }
}
