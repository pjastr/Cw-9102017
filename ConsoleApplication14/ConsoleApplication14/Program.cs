using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tablice = new int[5, 5];
            Random r = new Random();

            for (int i=0;i<5;i++)
            {
                for (int j=0;j<5;j++)
                {
                    
                    tablice[i, j] = r.Next(20, 50);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if(i%2==0 && j%2==0)
                    {
                        Console.WriteLine(tablice[i, j]);
                    }
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (i!=j)
                    {
                        Console.Write(tablice[i, j]+"  ");
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
