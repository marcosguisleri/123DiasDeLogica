using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio10
    {
        public static void Executar()
        {
            // Exercício 10.
            Console.WriteLine("Exercício 10:  \n");

            // Lógica do exercício 10
            Console.WriteLine("Quantidade de vendas camisas PEQUENAS: ");
            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de vendas camisas MÉDIAS: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quantidade de vendas camisas GRANDES: ");
            int g = Convert.ToInt32(Console.ReadLine());

            int total = (p * 8) + (m * 10) + (g * 15);

            Console.WriteLine($"O total arrecadado foi de R${total}");

        }
    }
}