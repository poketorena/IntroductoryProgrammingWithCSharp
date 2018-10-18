using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductoryProgrammingWithCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            Console.WriteLine("input x :");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("input y :");
            y = double.Parse(Console.ReadLine());

            z = x * x + y * y;
            x /= z;
            y /= -z;

            Console.WriteLine("({0},{1})", x, y);
        }
    }
}
