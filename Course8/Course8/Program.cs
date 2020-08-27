using System;

namespace Course8 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Ente com um número inteiro:");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                Console.WriteLine("Par!");
            } 
            else {
                Console.WriteLine("Impar!");
            }
        }
    }
}
