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
            Console.WriteLine("整数を入力してください");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("最大値は{0}です", Math.Max(x, Math.Max(y, z)));
            Console.WriteLine("最小値は{0}です", Math.Min(x, Math.Min(y, z)));
        }
    }
}
