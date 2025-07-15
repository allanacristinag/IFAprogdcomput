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
            Console.Write("Digite o lado A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o lado B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o lado C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Triângulo Equilátero.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Triângulo Isósceles.");
                }
                else
                {
                    Console.WriteLine("Triângulo Escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo.");
            }
        }
    }
}
