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
            Console.Write("半径を入力してください: ");
            double x = double.Parse(Console.ReadLine());

            double area = x * x * Math.PI;

            Console.Write("半径{0}の円の面積は{1}\n", x, area);
        }
    }
}
