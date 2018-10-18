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
            Console.Write("整数を入力してください：");
            int a = int.Parse(Console.ReadLine());
            Console.Write("整数を入力してください：");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / (double)b);
        }
    }
}
