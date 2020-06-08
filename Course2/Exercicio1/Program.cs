using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            
            string produto1 = "Cumputador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo o preço é R$ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo o preço é R$ {1:F2}", produto2, preco2);
            Console.WriteLine("\n");
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine("Seperador decimal invariant culture: {0}", medida.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
