using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFAlista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a nota da P1: ");
            double p1 = Convert.ToDouble(Console.ReadLine());
            double p2Necessaria = (15 - p1) / 2;

            if (p2Necessaria > 10)
            {
                Console.WriteLine("Infelizmente, não é possível alcançar a média 5. Você precisaria tirar mais de 10 na P2.");

            }
            else if (p2Necessaria <= 0)
            {
                Console.WriteLine("Você já está aprovado! Não precisa tirar nota na P2");
            }
            else
            {
                Console.WriteLine("Você Precisa tirar pelo menos: " + p2Necessaria.ToString("F2") + " na P2 para ser aprovado.");
            }


        }
    }
}
