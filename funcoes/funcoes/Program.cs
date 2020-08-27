﻿using System;

namespace funcoes {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três números:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        static int Maior(int a, int b, int c) {
            if (a > b && a > c) {
                return a;
            } else if (b > c) {
                return b;
            } else {
                return c;
            }
        }
    }
}
