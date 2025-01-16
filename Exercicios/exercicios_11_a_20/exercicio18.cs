using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio18
    {
        public static void Executar()
        {
            // Exercício 18.
            Console.WriteLine("Exercício 18: Declare 2 variáveis A e B, leia um valor para cada uma delas e disponibilize estes valores em ordem crescente. \n");

            // Lógica do exercício 18
            Console.WriteLine("Informe o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b) 
            {
                Console.WriteLine($"Valores em ordem crescente A: {a} | B: {b} ");
            } else 
            {
                Console.WriteLine($"Valores em ordem crescente B: {b} | A: {a} ");
            }
        
        }
    }
}
