using System;

namespace _9_IntroducaoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"Pedro", "Felipe", "Marcus", "Matheus"}; // Os colchetes significam que estamos declarando um array de texto
            
            Console.Write("Nome do N3: " + nomes[3]);
            nomes[3] = "Lucas"; //Mudando a informação da posição número 3 da lista
            Console.Write("\nNome do N3: " + nomes[3]);
            Console.ReadKey();
        }
    }
}
