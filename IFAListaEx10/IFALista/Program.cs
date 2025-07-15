using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFALista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int soma = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite o valor #" + i + ": ");
                int valor = Convert.ToInt32(Console.ReadLine());

                if (valor > maior)
                    maior = valor;

                soma += valor;
            }
            double media = soma / 10.0;

            Console.WriteLine("Maior valor: " + maior);
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
        }
    }
}
