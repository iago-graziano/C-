using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge #354 [Easy] Integer Complexity 1
namespace IntegerComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            long input = 1234567891011; //4-5s
            long result = 1 + input;

            for (int i = 1; i < Math.Sqrt(input); i++)
            {
                if ((input%i == 0) && ((i + (input / i)) < result))
                {
                    result = i + (input / i);
                }
            }

            stopwatch.Stop();
            Console.WriteLine(input.ToString() + "=> " + result.ToString());
            Console.WriteLine("Tempo: " + stopwatch.Elapsed.TotalMilliseconds);
        }
    }
}
