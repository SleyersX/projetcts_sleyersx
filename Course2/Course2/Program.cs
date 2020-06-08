using System;
using System.Globalization;

namespace Course2 {
    class Program {
        static void Main(string[] args) {
            char genero = 'M';
            int idade = 29;
            double saldo = 10.35784;
            string nome = "Walter Moura";

            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine("| Dados Cliente                                             |");
            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine("| Nome: " + nome + " | Genero: " + genero + " | Idade: " + idade + " | Saldo: " + saldo.ToString("F2",CultureInfo.InvariantCulture) + " |");
            Console.WriteLine("+-----------------------------------------------------------+");

            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine("| Dados Cliente                                             |");
            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine("| Nome: {0} | Genero: {1} | Idade: {2} | Saldo: {3:F2} |",nome,genero,idade,saldo);
            Console.WriteLine("+-----------------------------------------------------------+");

            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine("| Dados Cliente                                             |");
            Console.WriteLine("+-----------------------------------------------------------+");
            Console.WriteLine($"| Nome: {nome} | Genero: {genero} | Idade: {idade} | Saldo: {saldo:F2} |");
            Console.WriteLine("+-----------------------------------------------------------+");
        }
    }
}
