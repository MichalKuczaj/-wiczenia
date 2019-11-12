using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrójkaPitagorejska
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Program sprawdza czy podane cyfry a, b, c są trójką pitagorejską");
            Console.ReadLine();
            Console.WriteLine("Podaj a. ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b. ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj c. ");
            c = int.Parse(Console.ReadLine());

            if ((a * a + b * b) == c * c)
            {
                Console.Write("Liczby");
                Console.Write("a = " + a + " , ");
                Console.Write("b = " + b + " , ");
                Console.Write("c = " + c);
                Console.Write(" są trójką pitagorejską");
            }
            else
            {
                Console.Write("Liczby");
                Console.Write("a = " + a + " , ");
                Console.Write("b = " + b + " , ");
                Console.Write("c = " + c );
                Console.Write(" nie są trójką pitagorejską");
            }
            Console.ReadLine();
        }
    }
}
