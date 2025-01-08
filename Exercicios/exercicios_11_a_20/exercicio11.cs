using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio11
    {
        public static void Executar()
        {
            // Exercício 11.
            Console.WriteLine("Exercício 11: Construa um algoritmo para calcular a distância entre dois pontos do plano cartesiano. Cada ponto é um par ordenado (x,y).  \n");

            // Lógica do exercício 11
           Console.WriteLine("Informe o valor do ponto x1: ");
           double x1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Informe o valor do ponto y1: ");
           double y1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Informe o valor do ponto x2: ");
           double x2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Informe o valor do ponto y2: ");
           double y2 = Convert.ToDouble(Console.ReadLine());

           double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

           Console.WriteLine($"A distância entre os pontos é de {distancia:f1}");
        }
    }
}
