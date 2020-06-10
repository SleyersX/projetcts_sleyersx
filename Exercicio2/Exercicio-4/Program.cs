using System;
using System.Globalization;

namespace Exercicio_4 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com dois números inteiros ");
            Console.Write("Primeiro número: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Segundo número: ");
            int B = int.Parse(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine("Soma de {0} + {1} é igual á {2}", A, B, SOMA);

        }
    }
}
