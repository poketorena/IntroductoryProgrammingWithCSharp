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
            // 整数を2つ入力してもらう
            int x, y;
            Console.Write("1つ目の整数を入力してください : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("2つ目の整数を入力してください : ");
            y = int.Parse(Console.ReadLine());

            // + - / * のいずれかを入力してもらう
            char op;
            Console.Write("行いたい操作を入力してください(+ - / *) : ");
            op = Console.ReadLine()[0];

            switch (op)
            {
                case '+':
                    Console.Write("{0} + {1} = {2}", x, y, x + y);
                    break;
                case '-':
                    Console.Write("{0} - {1} = {2}", x, y, x - y);
                    break;
                case '*':
                    Console.Write("{0} × {1} = {2}", x, y, x * y);
                    break;
                case '/':
                    if (y != 0)
                        Console.Write("{0} ÷ {1} = {2} … {3}", x, y, x / y, x % y);
                    break;
                default:
                    Console.Write("対応していない操作です");
                    break;
            }
        }
    }
}
