using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge #364 [Easy] Create a Dice Roller
namespace DeD
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Soma: " + randomize(5,12));
        }

        public static int randomize(int times, int faces)
        {
            int sum = 0;
            Random rnd = new Random();

            for (int i=0; i < times; i++)
            {
                sum += rnd.Next(1, faces);
            }

            return sum;
        }
    }
}
