using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Challenge #361 [Easy] Tally Program
namespace TallyFriends
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Resultado> resultado = new List<Resultado>();
            string input = "dbbaCEDbdAacCEAadcB";

            resultado.Add(new Resultado
            {
                letra = 'a',
                qtd = 0
            });

            resultado.Add(new Resultado
            {
                letra = 'b',
                qtd = 0
            });

            resultado.Add(new Resultado
            {
                letra = 'c',
                qtd = 0
            });

            resultado.Add(new Resultado
            {
                letra = 'd',
                qtd = 2
            });

            resultado.Add(new Resultado
            {
                letra = 'e',
                qtd = 0
            });

            for (int i = 0; i < input.Length; i++)
            {
                input.ElementAt(i);
            }

            resultado.Sort();
           
        }
    }

    public class Resultado : IComparable
    {
        public int qtd;
        public char letra;

        public int CompareTo(object obj)
        {
            Resultado other = (Resultado)obj;
            if (this.qtd == other.qtd)
            {
                return this.qtd.CompareTo(other.qtd);
            }

            return other.qtd.CompareTo(this.qtd);
        }
    }
}
