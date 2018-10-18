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
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int max = Max(arr);
            int min = Min(arr);
            double avg = Average(arr);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(avg);
        }

        /// <summary>
        /// 配列中の最大値を求める
        /// </summary>
        /// <param name="a">対象の配列</param>
        /// <returns>最大値</returns>
        static int Max(int[] a)
        {
            int max_t = int.MinValue;
            foreach (var item in a)
            {
                if (item > max_t)
                {
                    max_t = item;
                }
            }
            return max_t;
        }

        /// <summary>
        /// 配列中の最小値を求める
        /// </summary>
        /// <param name="a">対象の配列</param>
        /// <returns>最小値</returns>
        static int Min(int[] a)
        {
            int min_t = int.MaxValue;
            foreach (var item in a)
            {
                if (item < min_t)
                {
                    min_t = item;
                }
            }
            return min_t;
        }

        /// <summary>
        /// 配列中の平均値を求める
        /// </summary>
        /// <param name="a">対象の配列</param>
        /// <returns>平均値</returns>
        static double Average(int[] a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }
            return sum / (double)a.Length;
        }
    }
}
