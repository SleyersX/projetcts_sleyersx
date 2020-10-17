using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

namespace GerarDigitoEAN {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o código EAN: ");
            string str = Console.ReadLine();

            char[] b = new char[str.Length];
            using (StringReader sr = new StringReader(str)) {
                sr.Read(b, 0, str.Length);
                Console.WriteLine(b);

            }

        }
    }
}
