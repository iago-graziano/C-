using System;
using System.Text;

//Desafio Iago - Calculo placa perfeita
namespace PerfectPlate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "HAE-3722";
            string[] split = new string[2];
            int soma_num = 0, num;
            int soma_letra = 0;

            int ini = DateTime.Now.Millisecond;

            split = input.Split('-');
            num = Convert.ToInt32(split[1]);

            soma_num += num / 1000;
            soma_num += ((num / 100) % 10);
            soma_num += ((num / 10) % 10);
            soma_num += num % 10;

            byte[] asciiBytes = Encoding.ASCII.GetBytes(split[0]);

            soma_letra += asciiBytes[0] - 64;
            soma_letra += asciiBytes[1] - 64;
            soma_letra += asciiBytes[2] - 64;
            Console.WriteLine(soma_num + " - " + soma_letra);

            int fim = DateTime.Now.Millisecond - ini;
            Console.WriteLine("Tempo: " + fim + "ms");
          
        }
    }
}
