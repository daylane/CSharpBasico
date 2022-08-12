using System;

namespace _04_VariavelChareString
{
    class Program
    {
        static void Main(string[] args)
        {
            char meuChar = '!'; // Representar apenas um caractere é aspas simples ('')
            string meuString = "Olá, Mundo"; // Sequencia de caracteres usa aspas duplas ("")

            Console.Write(meuString + meuChar);
            Console.ReadKey();
        }
    }
}
