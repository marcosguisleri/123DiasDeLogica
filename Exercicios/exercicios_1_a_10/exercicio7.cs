using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio7
    {
        public static void Executar()
        {
            // Exercício 07.
            Console.WriteLine("Exercício 7: O restaurante self-service BOMPRATO cobra R$14,00 por cada quilo de refeição. Escreva um algoritmo que leia o peso do prato montado pelo cliente (em quilos) e imprima o valor a pagar. Assuma que a balança já desconta o peso do prato (tara). \n");

            // Lógica do exercício 7

            Console.WriteLine("Digite o peso do prato montado pelo cliente (em quilos): ");
            double pesoPrato = double.Parse(Console.ReadLine());

            double valorPagar = pesoPrato * 14;

            Console.WriteLine($"O valor a pagar é de R${valorPagar:f2}");

        }
    }
}