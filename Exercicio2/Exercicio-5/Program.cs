using System;
using System.Globalization;

namespace Exercicio_5 {
    class Program {
        static void Main(string[] args) {

            double pi = 3.14159, area, resultado;

            Console.Write("Entre com valor da área ser calculada [A]: ");
            area = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = (pi * area * area);
            Console.WriteLine("Área [A] é igual {0}", resultado.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}
