using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio28
    {
        public static void Executar()
        {
            // Exercício 28.
            Console.WriteLine("Exercício 28: Elabore um algoritmo que lê 2 valores a e b e os escreva com a mensagem: São múltiplos ou Não são múltiplos. \n");

            // Lógica do exercício 28
            Console.WriteLine("Informe o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if(a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Os valores de A e B são múltiplos! ");
            }
            else
            {
                Console.WriteLine("Os valores de A e B não são múltiplos!");
            }
            
        }
    }
}
