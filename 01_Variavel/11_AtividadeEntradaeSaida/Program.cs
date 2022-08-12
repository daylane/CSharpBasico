using System;

namespace _11_AtividadeEntradaeSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            int Idade = int.Parse(Console.ReadLine());

            int ano = DateTime.Now.Year - Idade;
           

            Console.WriteLine("Ano de Nascimento de "+ Nome +" é "+ ano);
            Console.ReadKey();
        }
    }
}
