using System;

namespace _06_Constante
{
    class Program
    {
        static void Main(string[] args)
        {
            const bool Porta = true; //Apartir do momento que definir um valor utilizando const, o valor nunca será mudado.

            Console.WriteLine(Porta);
            Console.ReadKey();
        }
    }
}
