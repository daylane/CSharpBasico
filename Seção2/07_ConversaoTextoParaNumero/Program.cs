using System;

namespace _07_ConversaoTextoParaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumeroTexto = "10";
            int Numero = 40;
            int ConversaoNumero = int.Parse(NumeroTexto); // Converte a string para um tipo inteiro

            Console.Write("O Resultado da Soma é: " + (Numero + ConversaoNumero));
            Console.ReadKey();
        }
    }
}
