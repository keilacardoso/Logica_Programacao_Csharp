using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, numero = 1, tabuada, valorDigitado;

            Console.WriteLine("Digite o valor da tabuada que quer consultar: ");
            valorDigitado = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                tabuada = valorDigitado * numero;
                Console.WriteLine(tabuada); 
                numero = numero + 1;
                i++;
            }
        }
    }
}
