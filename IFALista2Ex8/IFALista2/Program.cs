using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFALista2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            double r = peso / (altura * altura);
            
            if (r < 20)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            else if (r < 25)
            {
                Console.WriteLine("Peso ideal.");
            }
            else
            {
                Console.WriteLine("Acima do peso.");
            }
        }
    }
}
