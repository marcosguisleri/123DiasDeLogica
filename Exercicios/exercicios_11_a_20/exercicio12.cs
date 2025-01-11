using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio12
    {
        public static void Executar()
        {
            // Exercício 12.
            Console.WriteLine("Exercício 12: Uma fábrica controla o tempo de trabalho sem acidentes pela quantidade de dias. Faça um algoritmo para converter este tempo em anos, meses e dias. Assuma que cada mês possui sempre 30 dias. \n");

            // Lógica do exercício 12
            Console.WriteLine("Informe a quantidade de dias: ");
            int totalDias = Convert.ToInt32(Console.ReadLine());

            int anos = totalDias / 360;
            int restoAnos = totalDias % 360;
            int meses = restoAnos / 30;
            int dias = restoAnos % 30;

            Console.WriteLine($"Tempo de trabalho sem acidentes: {anos} ano(s), {meses} mes(es) e {dias} dia(s).");
           
        }
    }
}
