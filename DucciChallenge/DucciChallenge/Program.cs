using System;

//Challenge #364 [Intermediate] The Ducci Sequence
/* 
0     100    350    600
100   250    250    600
150   0      350    500
150   350    150    350
200   200    200    200
0     0      0      0
*/
namespace DucciChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int anterior = 0;
            int acc = 0;
            int steps = 0;
            int[] ducci = new int[4];
            
            ducci[0] = 0;
            ducci[1] = 0;
            ducci[2] = 0;
            ducci[3] = 2;

            while (acc != 1)
            {
                if ((ducci[0] == 0) && (ducci[1] == 0) && (ducci[2] == 0) && (ducci[3] == 0))
                    acc = 1;
                else
                {
                    steps++;
                                                           
                    Console.WriteLine(steps.ToString() + " - [" + ducci[0].ToString() + "; " + ducci[1].ToString() + "; " + ducci[2].ToString() + "; " + ducci[3].ToString() + "]");
                    anterior = ducci[0];
                    ducci[0] = ducci[1] - ducci[0];
                    ducci[1] = ducci[2] - ducci[1];
                    ducci[2] = ducci[3] - ducci[2];
                    ducci[3] = anterior - ducci[3];

                    for (int i = 0; i < 4; i++)
                    {
                        if (ducci[i] < 0)
                        {
                            ducci[i] = ducci[i] * (-1);
                        }
                    }
                }
            } 
            steps++;
            Console.WriteLine(steps.ToString() + " - [" + ducci[0].ToString() + "; " + ducci[1].ToString() + "; " + ducci[2].ToString() + "; " + ducci[3].ToString() + "]");
        }
    }
}