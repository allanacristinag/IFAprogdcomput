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
            Console.Write("Digite o primeiro valor: ");
                int valor1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digte o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O maior valor é: " + valor1);
            }
            else if (valor1 < valor2)
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }
            else
            {
                Console.WriteLine("Os valores são idênticos.");
            }
        }
    }
}
