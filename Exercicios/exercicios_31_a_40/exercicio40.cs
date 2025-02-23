using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio40
    {
        public static void Executar()
        {
            // Exercício 40.
            Console.WriteLine("Exercício 39:  \n");

            // Lógica do exercício 40
            Console.WriteLine("Informe a hora de início do jogo: ");
            int horaInicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a hora de término do jogo: ");
            int horaFim = Convert.ToInt32(Console.ReadLine());

            int duracao = 0;

            if(horaFim > horaInicio)
            {
                duracao = horaFim - horaInicio;
            }
            else if(horaInicio == horaFim)
            {
                duracao = 24;
            }
            else
            {
                duracao = 24 - horaInicio + horaFim;
            }

            Console.WriteLine($"O jogo durou {duracao} horas.");

        }
    }
}
