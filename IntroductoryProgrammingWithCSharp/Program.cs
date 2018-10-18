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
            Console.Write("実数を入力してください：");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}をintへキャストした結果は{1}", a, (int)a);
        }
    }
}
