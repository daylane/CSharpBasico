using System;

namespace _08_ConversaoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            long meuLong = 10;
            int meuInt = System.Convert.ToInt32(meuLong); // Está convertendo uma variavel que possui 64bits para uma variavel de 32
            short meuShort = System.Convert.ToInt16(meuInt); // Está convertendo uma variavel que possui 32bits para uma variavel de 16

            Console.Write(meuShort);
            Console.ReadKey();
        }
    }
}
