using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio39
    {
        public static void Executar()
        {
            // Exercício 39.
            Console.WriteLine("Exercício 39: Elabore um algoritmo que lê 3 valores a, b, c e verifica se eles formam ou não um triângulo. Supor que os valores lidos são inteiros e positivos. Caso os valores formem um triângulo, calcule e escreva a área desse triângulo. Se não formam triângulo, escreva os valores lidos. (se a > b + c não formam triângulo algum, se a é o maior). \n");

            // Lógica do exercício 39
            Console.WriteLine("Informe o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                // Calcular semi-perímetro
                double s = (a + b + c) / 2.0;

                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                Console.WriteLine($"Os valores formam um triângulo.");
                Console.WriteLine($"A área do triângulo é: {area:F2}");
            }
            else
            {
                Console.WriteLine("Os valores não formam um triângulo.");
                Console.WriteLine($"Valores lidos: a = {a}, b = {b}, c = {c}");
            }
        }
    }
}
