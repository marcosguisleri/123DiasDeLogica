using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio5
    {
        public static void Executar()
        {
            // Exercício 05.
            Console.WriteLine("Exercício 5: O custo ao consumidor de um carro novo, é a soma do custo de fábrica com a percentagem do revendedor e com o custo dos impostos (aplicados ao custo de fábrica).Supondo que a percentagem do revendedor seja 25% e que os impostos custam 45% do custo de fábrica. Faça um algoritmo que leia o valor de custo de fábrica e determine o preço final do automóvel (preço ao consumidor). \n");

            // Lógica do exercício 5

            Console.WriteLine("Digite o valor do custo de fábrica do carro: ");
            double custoFabrica = double.Parse(Console.ReadLine());

            double percentagemRevendedor = 0.25;
            double impostos = 0.45;

            double precoFinal = custoFabrica + (custoFabrica * percentagemRevendedor) + (custoFabrica * impostos);

            Console.WriteLine($"O preço final do automóvel é de R$ {precoFinal}");
            
        }
    }
}