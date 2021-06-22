using System;

namespace MediaVendasFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorJaneiro, valorFevereiro, valorMarco, valorAbril; 
            double media, total;
            string vendedor;

            Console.WriteLine("Informe o nome do vendedor");
            vendedor = Console.ReadLine();
            Console.WriteLine("Informa o valor total de vendas de " + vendedor + " no mês de Janeiro: ");
            valorJaneiro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informa o valor total de vendas de " + vendedor + " no mês de Fevereiro: ");
            valorFevereiro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informa o valor total de vendas de " + vendedor + " no mês de Março: ");
            valorMarco = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informa o valor total de vendas de " + vendedor + " no mês de Abril: ");
            valorAbril = Convert.ToInt32(Console.ReadLine());

            total = valorJaneiro + valorFevereiro + valorMarco + valorAbril;
            media = total / 4;

            Console.WriteLine("O total de vendas do vendedor " + vendedor + " no primeiro quadrimestre é: " + total + "\n" +
                "Média: " + media);
        }
    }
}
