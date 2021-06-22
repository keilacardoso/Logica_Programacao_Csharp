using System;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;
            string nome;

            Console.WriteLine("Informe o nome do aluno:");
            nome = Console.ReadLine();
            Console.Write("Informe a nota 1:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a nota 2:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a nota 3:");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a nota 4:");
            nota4 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media >= 7)
            Console.WriteLine("A Média do aluno " + nome + " é: " + Math.Round(media, 2) + "\n" +
                "Aprovado!");
            else
                Console.WriteLine("A Média do aluno " + nome + " é: " + Math.Round(media, 2) + "\n" +
               "Reprovado!");
        }
    }
}
