using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFALista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double maior = x;

            if (y > x)
            {
                maior = y;
            }
            Console.WriteLine("O maior valor é: " + maior);
        }
    }
}
