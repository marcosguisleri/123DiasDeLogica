using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio37
    {
        public static void Executar()
        {
            // Exercício 37.
            Console.WriteLine("Exercício 37: Um vendedor precisa de um algoritmo que calcula o preço total devido por um cliente. O algoritmo deve receber o código de um produto e a quantidade comprada e calcular o preço total, usando a tabela abaixo. Mostre uma mensagem no caso de código inválido. \n");

            // Lógica do exercício 37
            Console.WriteLine("Informe o código do produto: ");
            string codProduto = (Console.ReadLine());   

            Console.WriteLine("Informe a quantidade comprada: ");
            int quantComprada = Convert.ToInt32(Console.ReadLine());

            double valorTotal = 0;

            switch (codProduto)
            {
                case "ABCD":
                    valorTotal = quantComprada * 5.30;
                    Console.WriteLine($"O preço total do produto comprado é: R$ {valorTotal} ");
                    break;
                case "XYPK":
                    valorTotal = quantComprada * 6.00;
                    Console.WriteLine($"O preço total do produto comprado é: R$ {valorTotal} ");
                    break;
                case "KLMP":
                    valorTotal = quantComprada * 3.20;
                    Console.WriteLine($"O preço total do produto comprado é: R$ {valorTotal} ");
                    break;
                case "QRST":
                    valorTotal = quantComprada * 2.50;
                    Console.WriteLine($"O preço total do produto comprado é: R$ {valorTotal} ");
                    break;
                default:
                    Console.WriteLine("O código do produto inserido é inválido! ");
                    break;
            }
        }
    }
}
