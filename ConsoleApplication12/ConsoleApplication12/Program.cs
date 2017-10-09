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
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Max(Math.Max(a, b), c));
            //Console.WriteLine(Math.Min(Math.Min(a, b), c));

            //int max = a;
            //if (b > max) max = b;
            //if (c > max) max = c;

            //int min = a;
            //if (b < min) min = b;
            //if (c < min) min = c;

            //Console.WriteLine("Max={0}, Min={1}", max, min);

            int[] tab1 = new int[] { a, b, c };
            Console.WriteLine("Max={0}, Min={1}", tab1.Max(), tab1.Min());
            Console.ReadKey();
        }
    }
}
