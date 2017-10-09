using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void WyswietlSume(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        
        //bardzo zła praktyka!!! 
        //static int Suma2(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //    return a + b;
        //}
        
        static void Main(string[] args)
        {
            Console.WriteLine(Suma(5, 6));
            WyswietlSume(4, 2);
            int[] tab = new int[30];
            tab[0] = 0;
            tab[1] = 1;
            int n = 2;
            while (tab.Max()<1000)
            {
                tab[n] = tab[n - 1] + tab[n - 2];
                n++;
            }

            for(int i=0;i<n-1;i++)
            {
                Console.Write(tab[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
