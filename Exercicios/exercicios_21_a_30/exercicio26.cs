using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio26
    {
        public static void Executar()
        {
            // Exercício 26.
            Console.WriteLine("Exercício 26: Calcule a média aritmética das 3 notas de um aluno e mostre, além do valor da média, uma mensagem de Aprovado, caso a média seja igual ou superior a 6,0 ou a mensagem reprovado, caso contrário. \n");

            // Lógica do exercício 26
            Console.WriteLine("Informe a primeira nota do aluno: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota do aluno: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota do aluno: ");
            double n3 = Convert.ToDouble(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if(media >= 6.0)
            {
                Console.WriteLine($"A média final do aluno é {media:f2}, resultado final APROVADO. ");
            }
            else
            {
                Console.WriteLine($"A média final do aluno é {media:f2}, resultado final REPROVADO. ");
            }
            
        }
    }
}
