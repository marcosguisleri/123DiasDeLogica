using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio27
    {
        public static void Executar()
        {
            // Exercício 27.
            Console.WriteLine("Exercício 27: Elabore um algoritmo que lê 3 valores a,b,c e os escreve. A seguir, encontre o maior dos 3 valores e o escreva com a mensagem: O valor ... é o maior . \n");

            // Lógica do exercício 27
            Console.WriteLine("Informe o valor de A: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de B: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de C: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int maior = a;

            if(b > maior)
            {
                maior = b;
                if(c > maior)
                {
                    maior = c;
                    Console.WriteLine($"O maior valor é C: {maior}");
                }
                else
                {
                    Console.WriteLine($"O maior valor é B: {maior}");
                }
            }
            else{
                Console.WriteLine($"O maior valor é A: {maior}");
            }
            
        }
    }
}
