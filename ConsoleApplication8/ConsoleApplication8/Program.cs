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
            int[,] tablica = new int[5, 5];
            for (int i=0; i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    tablica[i, j] = 3 * i * i + 5 * j - 2;
                }
            }

            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i!=j)
                    {
                        Console.Write(tablica[i, j]+"  ");
                    }
                    else 
                    {
                        Console.Write("   ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
