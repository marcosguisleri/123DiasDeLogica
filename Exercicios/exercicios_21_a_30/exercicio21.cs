using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio21
    {
        public static void Executar()
        {
            // Exercício 21.
            Console.WriteLine("Exercício 21: \n");

            // Lógica do exercício 21
            Console.WriteLine("Informe a quantidade de pães vendidos: ");
            int quantPao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade broas vendidads: ");
            int quantBroas = Convert.ToInt32(Console.ReadLine());

            double vendaTotal = (quantBroas * 1.50) + (quantPao * 0.35);
            double valorPoupanca = vendaTotal * 0.10;

            Console.WriteLine($"O valor total de venda dos produtos é R${vendaTotal:f2} e deve ser guardado R${valorPoupanca:f2} na poupança. ");
        }
    }
}
