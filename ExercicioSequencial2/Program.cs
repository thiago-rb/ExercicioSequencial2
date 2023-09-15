using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioSequencial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.14159;

            Console.Write("Digite o raio do circulo: ");
            raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2);

            Console.Write($"O valor da area do seu circulo é {area.ToString("F4", CultureInfo.InvariantCulture)}");

        }
    }
}
