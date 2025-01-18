using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio19
    {
        public static void Executar()
        {
            // Exercício 19.
            Console.WriteLine("Exercício 19: A imobiliária MOB vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno. \n");

            // Lógica do exercício 19
            Console.WriteLine("Informa o valor da base do terreno: ");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura do terreno: ");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"A área do terreno é {alturaRetangulo * baseRetangulo} ");
        
        }
    }
}
