using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio2
    {
        public static void Executar()
        {
            // Exercício 02.
            Console.WriteLine("Exercício 2: Leia o nome de uma pessoa, a sua idade e o seu salário, e mostre essas informações. ");

            // Lógica do exercício 2

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe seu salário: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome}, você tem {idade} anos e seu salário é R${salario:f2} ");
        }
    }
}