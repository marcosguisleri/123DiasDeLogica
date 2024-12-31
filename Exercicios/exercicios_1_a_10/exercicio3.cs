using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio3
    {
        public static void Executar()
        {
            // Exercício 03.
            Console.WriteLine("Exercício 3: Leia dois números, efetue as 4 operações matemáticas básicas e mostre os resultados. ");

            // Lógica do exercício 3

            Console.WriteLine("Informe o primeiro número: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine("Resultado das operações: ");
            Console.WriteLine($"A soma de {numero1} + {numero2} é igual a {soma}");
            Console.WriteLine($"A subtração de {numero1} - {numero2} é igual a {subtracao}");
            Console.WriteLine($"A multiplicação de {numero1} * {numero2} é igual a {multiplicacao}");
            Console.WriteLine($"A divisão de {numero1} / {numero2} é igual a {divisao}");
        }
    }
}