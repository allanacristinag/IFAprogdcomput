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
            Console.Write("Digite peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o sexo (M/F): ");
            char sexo = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            double r = peso / (altura * altura);
            if (sexo == 'F')
            {
                if (r < 19)
                {
                    Console.WriteLine("Abaixo do peso.");
                }
                else if (r < 24)
                {
                    Console.WriteLine("Peso ideal.");
                }
                else
                {
                    Console.WriteLine("Acima do peso.");
                }


            }
            else if (sexo == 'M')
            {
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
            else
            {
                Console.WriteLine("sexo inválido. Use 'M' ou 'F'.");
            }
        }
    }
}
