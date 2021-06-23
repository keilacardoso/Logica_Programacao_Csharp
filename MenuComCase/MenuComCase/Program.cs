using System;

namespace MenuComCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Console.WriteLine("1 - Netflix" + "\n");
            Console.WriteLine("2 - Amazon Prime" + "\n");
            Console.WriteLine("3 - Disney Plus" + "\n");
            Console.WriteLine("4 - Sair" + "\n");
            Console.WriteLine("Sua Opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.WriteLine("Iniciando Netflix..");
                    break;

                case 2:
                    Console.WriteLine("Iniciando Amazon Prime..");
                    break;

                case 3:
                    Console.WriteLine("Iniciando Disney Plus");
                    break;

                case 4:
                    Console.WriteLine("Encerrando..");
                    break;

                default:
                    Console.WriteLine("Você precisa selecionar as opções 1, 2, 3 ou 4");
                    break;

            }


        }

    }
}
