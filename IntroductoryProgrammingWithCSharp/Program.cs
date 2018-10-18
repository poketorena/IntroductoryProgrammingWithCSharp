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
            Console.Write("身長[cm] = ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("体重[kg] = ");
            double weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height / 10000);

            if (bmi < 19.8)
            {
                Console.WriteLine("痩せ型です");
            }
            else if (bmi < 24.2)
            {
                Console.WriteLine("普通です");
            }
            else if (bmi < 26.4)
            {
                Console.WriteLine("やや肥満（過体重）です");
            }
            else if (bmi < 35.0)
            {
                Console.WriteLine("肥満です");
            }
            else
            {
                Console.WriteLine("高度肥満（要治療）です");
            }
        }
    }
}
