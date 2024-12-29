using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio1
    {
        public static void Executar()
        {
            // Exercício 01.
            Console.WriteLine("Exercício 1: Descrição do problema");

            // Lógica do exercício 1

            Console.WriteLine("Informe a primeira nota: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A média das notas é: {(nota1 + nota2) / 2:f2}");
        }
    }
}
