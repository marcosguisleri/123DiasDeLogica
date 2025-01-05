using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio6
    {
        public static void Executar()
        {
            // Exercício 06.
            Console.WriteLine("Exercício 6: Um motorista deseja colocar no seu tanque X reais de gasolina. Escreva um algoritmo para ler o preço do litro da gasolina e o valor do pagamento, e exiba quantos litros ele conseguiu colocar no tanque. ");

            // Lógica do exercício 6

            Console.WriteLine("Digite o preço do litro da gasolina: ");
            double precoLitro = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do pagamento: ");
            double valorPagamento = double.Parse(Console.ReadLine());

            double litros = valorPagamento / precoLitro;

            Console.WriteLine($"Você conseguiu colocar {litros:f2} litros no tanque.");
        
        }
    }
}