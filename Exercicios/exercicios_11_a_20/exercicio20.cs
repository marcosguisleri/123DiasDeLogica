using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio20
    {
        public static void Executar()
        {
            // Exercício 20.
            Console.WriteLine("Exercício 20: Faça um algoritmo para calcular quantas ferraduras são necessárias para equipar todos os cavalos comprados para um haras. \n");

            // Lógica do exercício 20
           Console.WriteLine("Informe a quantidade de cavalos comprados: ");
           int quantCavalos = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine($"A quantidade de ferraduras necessárias para equipar todos os cavalos é {quantCavalos * 4}");
        
        }
    }
}
