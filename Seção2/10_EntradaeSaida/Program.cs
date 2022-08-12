using System;

namespace _10_EntradaeSaida
{
    class Program
    {
        static void Main(string[] args)
        {
           //Entrada

        /* int CodigoASCII = Console.Read(); //Lê um caractee e retorno o valor na tabela ASCII
           char Letra = (char)CodigoASCII;  // Transforma o Código DEC em Letra
           Console.WriteLine("Código DEC: " + CodigoASCII+ "\nLetra: " + Letra);*/

        /*  ConsoleKeyInfo Tecla = Console.ReadKey(); //Lê a tecla pressionada
            Console.WriteLine(" Tecla Digitada: " + Tecla.KeyChar); //Lê tecla pressionada e transforma em CHAR */


            string Frase =  Console.ReadLine(); // Recebe todos os caracteres digitadas
            Console.WriteLine(Frase);

            //Saida


            //Console.Write("Nome"); 
            //Console.WriteLine("nome"); //Tem quebra de linha
        }
    }
}
