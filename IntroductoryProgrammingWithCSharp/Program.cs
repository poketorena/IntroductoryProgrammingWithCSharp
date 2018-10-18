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
            try
            {
                checked
                {
                    sbyte a = 64;
                    sbyte b = 65;
                    sbyte c = (sbyte)(a + b);
                }
            }
            catch (OverflowException ex)
            {
                Console.Write(ex.Message);
                throw;
            }
        }
    }
}
