using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio25
    {
        public static void Executar()
        {
            // Exercício 25.
            Console.WriteLine("Exercício 25: Faça um algoritmo que leia o tempo de duração de um evento em uma fábrica expressa em segundos e mostre-o expresso em horas, minutos e segundos. \n");

            // Lógica do exercício 25
            Console.WriteLine("Informe o tempo de duração do evento em segundos: ");
            int tempoDuracao = Convert.ToInt32(Console.ReadLine());

            int horas = tempoDuracao / 3600;
            int minutos = (tempoDuracao % 3600) / 60;
            int segundos = tempoDuracao % 60;

            Console.WriteLine($"O evento teve duração de: {horas}h {minutos}m {segundos}s");
        }
    }
}
