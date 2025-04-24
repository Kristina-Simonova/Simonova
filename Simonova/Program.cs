using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simonova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение парамаетра х = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 3 * Math.Sin(x + 2);
            Console.WriteLine("3Sin(x + 2) = " + F);

            Console.ReadKey();
        }
    }
}
