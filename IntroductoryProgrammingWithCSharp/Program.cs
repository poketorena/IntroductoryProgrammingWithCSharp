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
            for (int i = 0; i < 150; i++)
            {
                if (Math.Pow(i + 1, 2) > 150)
                {
                    break;
                }
                if (x == (int)Math.Pow(i + 1, 2))
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            Console.WriteLine("NO");
        }
    }
}
