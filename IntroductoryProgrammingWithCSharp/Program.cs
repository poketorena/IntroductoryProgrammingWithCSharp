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
            //var arr = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //var arr2 = new[] { 1.0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max = Max(arr);
            //double max2 = Max(arr2);
            //int min = Min(arr);
            //double avg = Average(arr);
            //double pow = Power(5, 3);
            var max = Max(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine(max);
            //Console.WriteLine(max2);
            //Console.WriteLine(min);
            //Console.WriteLine(avg);
            //Console.WriteLine(pow);
        }

        /// <summary>
        /// 配列中の最大値を求める。
        /// </summary>
        /// <param name="a">対象の配列</param>
        /// <returns>最大値</returns>
        static int Max(params int[] a)
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
        /// 配列中の最大値を求める。
        /// </summary>
        /// <param name="a">対象の配列</param>
        /// <returns>最大値</returns>
        static double Max(double[] a)
        {
            double max_t = double.MinValue;
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
        /// 配列中の最小値を求める。
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
        /// 配列中の平均値を求める。
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

        /// <summary>
        /// xの整数冪を求める。
        /// </summary>
        /// <param name="x">仮数</param>
        /// <param name="n">指数</param>
        /// <returns>xのn乗</returns>
        static double Power(double x, int n)
        {
            double pow = 1;
            for (int i = 0; i < n; i++)
            {
                pow *= x;
            }
            return pow;
        }
    }
}
