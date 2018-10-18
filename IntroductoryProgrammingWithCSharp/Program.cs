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
            // 2*2の行列の積を求めるプログラム(n*nは未対応)
            Console.WriteLine("配列の長さを入力して下さい");
            int length = int.Parse(Console.ReadLine());
            var a = new int[length, length];
            var b = new int[length, length];
            Console.WriteLine("一つ目の配列の要素を入力して下さい");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("二つ目の配列の要素を入力して下さい");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }

            var c = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < c.GetLength(0); j++)
                {
                    for (int k = 0; k < c.GetLength(1); k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j].ToString().PadLeft(2, ' '));
                }
                Console.Write("\n");
            }
        }
    }
}
