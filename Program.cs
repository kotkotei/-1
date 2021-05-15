using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var r = 4;
            var result = (1 - Math.PI * 4 * r * r * r / 3 / a / a / a) * 100;
            Console.WriteLine(result.ToString("#.##"));
            Console.ReadKey();

        }
    }
}
