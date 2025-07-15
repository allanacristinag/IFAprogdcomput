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
            Console.Write("Digite o diâmetro do círculo: ");
            double diametro = Convert.ToDouble(Console.ReadLine());
            double raio = diametro / 2;
            double area = Math.PI * raio * raio;
            Console.WriteLine("A área do círculo é: " + area);
        }
    }
}
