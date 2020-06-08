using System;

namespace Course4 {
    class Program {
        static void Main(string[] args) {
            //Conversão implicita
            float x = 4.5f;
            
            double y = x;

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float)a;

            Console.WriteLine(b);

            int c;

            c = (int)a;
            Console.WriteLine(c);

            int d = 5;
            int e = 2;

            double resultado = (double) d / e;

            Console.WriteLine(resultado);
        }
    }
}
