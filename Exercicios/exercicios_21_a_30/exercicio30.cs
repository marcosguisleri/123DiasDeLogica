using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio30
    {
        public static void Executar()
        {
            // Exercício 30.
            Console.WriteLine("Exercício 30: Escreva um algoritmo que leia o RA (código) de um aluno e suas três notas. Calcule a média ponderada do aluno, considerando que o peso para a maior nota seja 4 e para as duas restantes, 3. Mostre o RA do aluno, suas três notas, a média calculada e uma mensagem APROVADO se a média for maior ou igual a 5 e REPROVADO se a média for menor que 5. \n");

            // Lógica do exercício 30
            Console.WriteLine("Informe o RA do aluno: ");
            int ra = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a primeira nota do aluno: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double maior = Math.Max(n1, Math.Max(n2, n3));

            double media;

            if(n1 != maior && n2 != maior)
            {
                media = ((maior * 4) + (n1 * 3) + (n2 * 3)) / 10;
            }
            else if(n2 != maior && n3 != maior)
            {
                media = ((maior * 4) + (n2 * 3) + (n3* 3)) / 10;
            }
            else
            {
                media = ((maior * 4) + (n1 * 3) + (n3* 3)) / 10;
            }

            Console.WriteLine($"RA do aluno: {ra} ");
            Console.WriteLine($"Nota 1: {n1:f2} | Nota 2: {n2:f2} | Nota 3: {n3:f2} ");
            Console.WriteLine($"A média final é {media} ");

            if(media >= 5)
            {
                Console.WriteLine("Aluno APROVADO ");
            }
            else
            {
                Console.WriteLine("Aluno REPROVADO ");
            }
        }
    }
}
