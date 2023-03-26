using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _022.teglalapkerter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a téglalap egyik oldalát!");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a téglalap másik oldalát és kiírom a területét!");
            int b = Convert.ToInt32(Console.ReadLine());
            int terulet = a * b;
            Console.WriteLine("A négyzet kerülete " + terulet + " cm2." + "\n");

            Console.WriteLine("Kérem a téglalap egyik oldalát!");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a téglalap másik oldalát és kiírom a kerületét!");
            int b2 = Convert.ToInt32(Console.ReadLine());
            int kerulet = (a2 + b2) * 2;
            Console.WriteLine("A négyzet területe " + kerulet + " cm." + "\n");

            Console.ReadKey();
        }
    }
}
