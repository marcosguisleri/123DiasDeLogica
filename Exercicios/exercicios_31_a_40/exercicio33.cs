using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio33
    {
        public static void Executar()
        {
            // Exercício 33.
            Console.WriteLine("Exercício 33: Tendo como dados de entrada a altura e o sexo de uma pessoa, M = masculino e F = feminino, construa um algoritmo que calcule seu peso ideal \n");

            // Lógica do exercício 33
            Console.WriteLine("Informe o sexo da pessoa M ou F: ");
            string sexo = Console.ReadLine();

            Console.WriteLine("Informe a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double pesoIdeal = 0;

            if(sexo == "F")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:f2} ");
            }
            else if(sexo == "M")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"Seu peso ideal é {pesoIdeal:f2} ");
            }
            else{
                Console.WriteLine($"Sexo inválido! Digite 'M' para masculino ou 'F' para feminino. ");
            }
            
        }
    }
}
