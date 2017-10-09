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
            Console.WriteLine("Podaj symbol temperatury");
            //int numerZnaku = Console.Read();
            //char znak = (char)numerZnaku;
            //Console.ReadLine();
            ConsoleKeyInfo klawisz = Console.ReadKey();
            char znak = klawisz.KeyChar;
            Console.WriteLine("\nPodaj wartosc temp");
            double temp = Double.Parse(Console.ReadLine());
            if (znak =='K')
            {
                Console.WriteLine("coś tam K");
            }
            else if (znak == 'C')
            {
                Console.WriteLine("coś tam C");
            }
            else if (znak == 'F')
            {
                Console.WriteLine("coś tam F");
            }

            Console.ReadKey();
        }
    }
}
