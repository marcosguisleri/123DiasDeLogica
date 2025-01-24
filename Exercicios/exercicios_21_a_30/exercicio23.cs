using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio23
    {
        public static void Executar()
        {
            // Exercício 23.
            Console.WriteLine("Exercício 23: Faça um algoritmo que leia a idade de uma pessoa expressa em dias e mostre-a expressa em anos, meses e dias. \n");

            // Lógica do exercício 23
            Console.WriteLine("Expresse sua idade em dias: ");
            int dias = Convert.ToInt32(Console.ReadLine());

            int anos = dias / 365;
            int restoAnos = dias % 365;

            int meses = restoAnos / 30;
            int restoMeses = restoAnos % 30;

            int diasResto = restoMeses % 30;
    
            Console.WriteLine($"A idade informada corresponde a {anos} ano(s), {meses} mes(es) e {diasResto} dia(s).");
        }
    }
}
