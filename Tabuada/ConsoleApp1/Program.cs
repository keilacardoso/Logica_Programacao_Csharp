using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, numero = 1;

            while (i <= 10)
            {
                int tabuada = 9 * numero;
                Console.WriteLine(tabuada); //tabuada do 9
                numero = numero + 1;
                i++;
            }
        }
    }
}
