using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio35
    {
        public static void Executar()
        {
            // Exercício 35.
            Console.WriteLine("Exercício 35: Um usuário deseja um algoritmo onde possa escolher que tipo de média deseja calcular a partir de 3 valores. Faça um algoritmo que leia os valores, a opção escolhida pelo usuário e calcule a média. \n");

            // Lógica do exercício 35
            Console.WriteLine("Informe o primeiro valor: ");
            double n1 =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo valor: ");
            double n2 =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o terceiro valor: ");
            double n3 =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("====================================");
            Console.WriteLine("  Escolha o tipo de média desejada:  ");
            Console.WriteLine("====================================");
            Console.WriteLine("1. Média Aritmética");
            Console.WriteLine("2. Média Ponderada (3, 3, 4)");
            Console.WriteLine("3. Média Harmônica");
            Console.WriteLine("====================================");
            Console.Write("Digite o número da opção desejada: ");
            int escolhaMedia = Convert.ToInt32(Console.ReadLine()); 

            double media = 0;

            if(escolhaMedia == 1)
            {
                media = (n1 + n2 + n3) / 3;
                Console.WriteLine($"A média aritmética dos três valores é: {media:f2} ");
            }
            else if(escolhaMedia == 2)
            {
                media = ((n1 * 3) + (n2 * 3) + (n3 * 4)) / 10;
                Console.WriteLine($"A média ponderada (3, 3, 4) dos três valores é: {media:f2} ");
            }
            else if (escolhaMedia == 3)
            {
                double somaInversos = (1 / n1) + (1 / n2) + (1 / n3); 
                media = 3 / somaInversos; 
                Console.WriteLine($"A média harmônica dos três valores é: {media:f2}");
            }
            else
            {
                Console.WriteLine("Opção inválida! Tente novamente.");
            }

        }
    }
}
