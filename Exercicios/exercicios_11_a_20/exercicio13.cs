using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio13
    {
        public static void Executar()
        {
            // Exercício 13.
            Console.WriteLine("Exercício 13: O sistema de avaliação de uma determinada disciplina é composto por três provas. A primeira prova tem peso 2, a segunda tem peso 3 e a terceira tem peso 5. Faça um algoritmo para calcular a média final de um aluno desta disciplina. \n");

            // Lógica do exercício 13
            Console.WriteLine("Informe a nota da primeira prova: ");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da segunda prova: ");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a nota da terceira prova: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A médias das notas é: {(nota1 * 2 + nota2 * 3 + nota * 5) / 10:f1}");

        }
    }
}
