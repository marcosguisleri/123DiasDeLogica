using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio36
    {
        public static void Executar()
        {
            // Exercício 36.
            Console.WriteLine("Exercício 36: \n");

            // Lógica do exercício 36
            Console.WriteLine("Informe o código do produto: ");
            int idProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade comprada: ");
            int quantComprada = Convert.ToInt32(Console.ReadLine());

            double valorFinal = 0;

            switch(idProduto)
            {
                case 1001:
                    valorFinal = quantComprada * 5.32;
                    Console.WriteLine($"Preço total devido pelo cliente: R$ {valorFinal:f2} ");
                    break;
                case 1324:
                    valorFinal = quantComprada * 6.45;
                    Console.WriteLine($"Preço total devido pelo cliente: R$ {valorFinal:f2} ");
                    break;
                case 6548:
                    valorFinal = quantComprada * 2.37;
                    Console.WriteLine($"Preço total devido pelo cliente: R$ {valorFinal:f2} ");
                    break;
                case 0987:
                    valorFinal = quantComprada * 5.32;
                    Console.WriteLine($"Preço total devido pelo cliente: R$ {valorFinal:f2} ");
                    break;
                case 7623:
                    valorFinal = quantComprada * 6.45;
                    Console.WriteLine($"Preço total devido pelo cliente: R$ {valorFinal:f2} ");
                    break;
                default:
                    Console.WriteLine($"Código do produto inválido! ");
                    break;
            }
        }
    }
}
