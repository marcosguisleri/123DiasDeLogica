using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio4
    {
        public static void Executar()
        {
            // Exercício 04.
            Console.WriteLine("Exercício 4: Duas variáveis (A e B) possuem valores distintos( A = 5 e B = 10). Crie um algoritmo que armazene estes dois valores nessas duas variáveis, e efetue a troca dos valores de forma que a variável A passe a possuir o valor de B e que a variável B passe a possuir o valor de A. Por fim, apresente estes valores trocados. ");

            // Lógica do exercício 4
            int a = 5;
            int b = 10;
            int c = a;

            a = b;
            b = c;

            Console.WriteLine($"A = {a} e B = {b}");
        }
    }
}