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
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; (i + 1) * (i + 1) <= n; i++)
            {
                if (n == (i + 1) * (i + 1))
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }
            Console.WriteLine("No");
        }
    }
}
