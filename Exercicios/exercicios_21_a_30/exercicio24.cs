using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio24
    {
        public static void Executar()
        {
            // Exercício 24.
            Console.WriteLine("Exercício 24: Faça um algoritmo que leia as 3 notas de um aluno e calcule a média final deste aluno. Considere que a média é ponderada e que o peso das notas é: 2,3 e 5, respectivamente. \n");

            // Lógica do exercício 24
            Console.WriteLine("Informe a primeira nota do aluno: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno: ");
            double n2 = Convert.ToDouble(Console.ReadLine());   

            Console.WriteLine("Informe a terceira nota do aluno: ");
            double n3 = Convert.ToDouble(Console.ReadLine());   

            Console.WriteLine($"A nota final do aluno é {((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10:f2}");
        }
    }
}
