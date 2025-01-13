using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio15
    {
        public static void Executar()
        {
            // Exercício 15.
            Console.WriteLine("Exercício 15: Uma empresa de venda de softwares paga a seu vendedor um salário fixo de R$800,00 por mês, mais uma comissão de 15% pelo seu valor de vendas no mês. Faça um algoritmo que leia o valor da venda e determine o salário total do funcionário. Mostre as informações processadas. \n");

            // Lógica do exercício 15
            Console.WriteLine("Informe o valor de vendas do mês do funcionário: ");
            double valorVendas = Convert.ToDouble(Console.ReadLine());

            double valorTotal = valorVendas * 0.15 + 800;

            Console.WriteLine($"Salário total do funcionário: R${valorTotal:f2}");

        }
    }
}
