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
            Console.Write("文字を入力してください");
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine("文字コードは{0}", (int)c);
        }
    }
}
