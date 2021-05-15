using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число n1");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a1");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число n2");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double an1a1n2 = (a * n1 + a1 * n2) / 100;
            Console.ReadKey();

        }
    }
}
