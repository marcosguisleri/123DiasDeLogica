using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio32a
    {
        public static void Executar()
        {
            // Exercício 32a.
            Console.WriteLine("Exercício 32a: Escreva um algoritmo que leia o código do item pedido, a quantidade e calcule o valor a ser pago por aquele lanche. Considere que a cada execução somente será calculado um item. \n");

            // Lógica do exercício 32a
            Console.WriteLine("Informe o código do produto: ");
            int codigoProduto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade: ");
            int quantProduto = Convert.ToInt32(Console.ReadLine());

            double valorFinal = 0;
            bool codigoValido = true;

            switch (codigoProduto)
            {
                case 100: valorFinal = quantProduto * 1.20; break;
                case 101: valorFinal = quantProduto * 1.30; break;
                case 102: valorFinal = quantProduto * 1.50; break;
                case 103: valorFinal = quantProduto * 1.20; break;
                case 104: valorFinal = quantProduto * 1.30; break;
                case 105: valorFinal = quantProduto * 1.00; break;
                default:
                    codigoValido = false;
                    Console.WriteLine("Código Inválido!");
                    break;
            }

            // Saída de dados (só exibe o preço se o código for válido)
            if (codigoValido)
            {
                Console.WriteLine($"O valor final é R$ {valorFinal:F2}");
            }
        }
    }
}

            