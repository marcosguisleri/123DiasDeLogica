using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio9
    {
        public static void Executar()
        {
            // Exercício 09.
            Console.WriteLine("Exercício 9: Faça um algoritmo para ler três notas de um aluno em uma disciplina e imprima a sua média ponderada (as notas tem pesos respectivos de 1, 2 e 3). \n");

            // Lógica do exercício 9
            Console.WriteLine("Informe a primeira nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: "); 
            double n3 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 * 1) + (n2 * 2) + (n3 * 3);

            Console.WriteLine($"A média ponderada é {media / 6}");

        }
    }
}