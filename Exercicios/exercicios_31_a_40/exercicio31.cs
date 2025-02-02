using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio31
    {
        public static void Executar()
        {
            // Exercício 31.
            Console.WriteLine("Exercício 31: Faça um algoritmo que leia um nº inteiro e mostre uma mensagem indicando se este número é par ou ímpar, e se é positivo ou negativo. \n");

            // Lógica do exercício 31
            Console.WriteLine("Informe um valor: ");
            int x = Convert.ToInt32(Console.ReadLine());    

            string paridade = (x % 2 == 0) ? "par" : "impar";
            string sinal = (x > 0) ? "positivo" : "negativo";
            
            Console.WriteLine($"Número {paridade} e {sinal}!");
            
        }
    }
}
