using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Challenge #362 [Intermediate] "Route" Transposition Cipher
namespace TranspositionCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean clockwise = false;
            Boolean counter_clockwise = false;
            string input = "This is an example (6, 3) clockwise";
            int lines, columns;

            if (input.Contains("clockwise"))
                clockwise = true;
            else
                counter_clockwise = true;

            lines = Convert.ToInt32(input.Substring(input.IndexOf("(") + 1, 1));
            columns = Convert.ToInt32(input.Substring(input.IndexOf("(") + 4, 1));
            input = input.Substring(0, input.IndexOf("(") - 1);

            char[,] matrix = new char[columns, lines];
            char[] teste = new char[20];

            int k = 0;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    matrix[i, j] = input.ElementAt(k);
                    k++;
                }
            }

            int l = 0;
            for (int i = 0; i < input.Count(); i++)
            {
                //if((input.ElementAt(i) > 'a') && (input.ElementAt(i) < 'Z'))
                //{
                    teste[l] = input.ElementAt(i);
                    l++;
                //}
            }

            Console.Write(teste);
            
            /*
            //Mostrando a matriz
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < lines; j++)
                {
                    Console.Write(matrix[i, j].ToString());
                }
                Console.WriteLine();
            }*/
        }
    }
}
