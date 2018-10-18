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
            Console.WriteLine("配列の長さを入力して下さい");
            int length = int.Parse(Console.ReadLine());
            var a = new int[length];
            Console.WriteLine("配列の要素を入力して下さい");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int max = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    max = a[i];
                }
                else
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
            }
            Console.WriteLine("最大値" + max);

            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    min = a[i];
                }
                else
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                    }
                }
            }
            Console.WriteLine("最小値" + min);
        }
    }
}
