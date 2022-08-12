using System;

namespace _01_Variavel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte meuByte; // Nome Abreviado
            System.Byte meuByte2; // Classe o qual o nome abreviado faz referência.

            meuByte = 9;
            meuByte2 = 10;

            sbyte meuSByte = -11; // Armazena números positivos e negativos.

            Console.Write(meuByte + meuByte2);
            Console.ReadKey();
        }
    }
}
