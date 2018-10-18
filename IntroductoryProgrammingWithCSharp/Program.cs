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
            var a = new int[21];

            a[0] = 3;
            a[1] = 1;
            for (int i = 2; i < a.Length; i++)
            {
                a[i] = 2 * a[i - 1] - 2 * a[i - 2];
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
