using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio22
    {
        public static void Executar()
        {
            // Exercício 22.
            Console.WriteLine("Exercício 22: Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e mostrea expressa apenas em dias. \n");

            // Lógica do exercício 22
            Console.WriteLine("Expresse sua idade em anos, meses e dias um abaixo do outro: ");
            int anos = Convert.ToInt32(Console.ReadLine());
            int meses = Convert.ToInt32(Console.ReadLine());
            int dias = Convert.ToInt32(Console.ReadLine());

            int diasAnos = anos * 365;
            int diasMeses = meses * 30;
            int diasTotal = diasAnos + diasMeses + dias;

            Console.WriteLine($"A sua idade expressa apenas em dias é: {diasTotal}" );
        }
    }
}
