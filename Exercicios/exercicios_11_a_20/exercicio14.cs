using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio14
    {
        public static void Executar()
        {
            // Exercício 14.
            Console.WriteLine("Exercício 14: Um cliente de um banco tem um saldo positivo de R$500,00. Faça um algoritmo que leia um cheque que entrou (compensado) e calcule o novo saldo, mostrando (escrevendo) o saldo na tela.  \n");

            // Lógica do exercício 14
            Console.WriteLine("Seu saldo atual: R$ 500,00 \n");

            Console.WriteLine("Informe o valor do cheque compensado: ");
            double cheque = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nSeu novo saldo é: {cheque + 500:f2} ");
        }
    }
}
