using System;

namespace _123_dias_logica.Exercicios.Exercicios_1_a_10
{
    public class Exercicio8
    {
        public static void Executar()
        {
            // Exercício 08.
            Console.WriteLine("Exercício 8: Entre com o dia e o mês de uma data e informe quantos dias se passaram desde o início do ano. Esqueça a questão dos anos bissextos e considere sempre que um mês possui 30 dias. \n");

            // Lógica do exercício 8

            Console.WriteLine("Informe o dia: ");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o mês: ");
            int mes = int.Parse(Console.ReadLine());

            int tempo = (mes - 1) * 30 + dia;

            Console.WriteLine($"Se passaram desde do início do ano {tempo} dia(s).");

        }
    }
}