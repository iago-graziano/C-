using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge #363 [Easy] I before E except after C
namespace IbeforeE
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "a";
            int flag = 0; //flag == 1 significa que segue a regra


            if (input.Contains("ei")) //tem que ter 'C' antes
            {
                if (input.Contains("cei"))
                    flag = 1;
            }

            if (input.Contains("ie")) // não pode ter 'C' antes
            {
                if (!input.Contains("cie"))
                    flag = 1;
            }

            if (!input.Contains("ie") || !input.Contains("ei"))
                flag = 1;

            if (flag == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
