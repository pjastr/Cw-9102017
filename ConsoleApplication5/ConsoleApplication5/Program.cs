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
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine()), c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Math.Max(Math.Max(a,b), c));
            //Console.WriteLine(Math.Min(Math.Min(a,b) ,c));
            

            //int[] tab = new int[] {a,b,c};
            //Console.WriteLine("Max: {0}\nMin: {1}", tab.Max(), tab.Min());

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            int min = a;
            if (b < max) min = b;
            if (c < max) min = c;
            Console.WriteLine("Max = {0}, Min = {1}", max, min);

            Console.ReadKey();
        }
    }
}
