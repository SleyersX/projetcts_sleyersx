using System;

namespace exercicio_1_objetos {
    class Program {
        static void Main(string[] args) {
           
            Pessoas pessoa_1 = new Pessoas();
            Pessoas pessoa_2 = new Pessoas();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            pessoa_1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa_1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            Console.Write("Nome: ");
            pessoa_2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa_2.Idade = int.Parse(Console.ReadLine());

            if (pessoa_1.Idade > pessoa_2.Idade) {
                Console.WriteLine("Pessoal mais velha: " + pessoa_1.Nome);
            }else if(pessoa_2.Idade > pessoa_1.Idade) {
                Console.WriteLine("Pessoa mais velha: " + pessoa_2.Nome);
            }
        }
    }
}
