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
            Console.WriteLine("BMI = {0}", bmi);
        }
    }
}
