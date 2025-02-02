using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio32b
    {
        public static void Executar()
        {
            Console.WriteLine("Exercício 32b: Agora o pedido pode incluir diversos itens. Digite 0 para finalizar.\n");

            double valorTotal = 0;

            while (true) 
            {
                Console.Write("Informe o código do produto (ou 0 para finalizar): ");
                int codigoProduto = Convert.ToInt32(Console.ReadLine());

                if (codigoProduto == 0) // Condição de saída
                {
                    break;
                }

                Console.Write("Informe a quantidade: ");
                int quantProduto = Convert.ToInt32(Console.ReadLine());

                double precoItem = 0;
                bool codigoValido = true;

                switch (codigoProduto)
                {
                    case 100: precoItem = 1.20; break;
                    case 101: precoItem = 1.30; break;
                    case 102: precoItem = 1.50; break;
                    case 103: precoItem = 1.20; break;
                    case 104: precoItem = 1.30; break;
                    case 105: precoItem = 1.00; break;
                    default:
                        codigoValido = false;
                        Console.WriteLine("Código Inválido! Tente novamente.");
                        break;
                }

                if (codigoValido)
                {
                    double valorFinal = quantProduto * precoItem;
                    valorTotal += valorFinal;
                    Console.WriteLine($"Item adicionado: R$ {valorFinal:F2}\n");
                }
            }

            Console.WriteLine($"\nTotal do pedido: R$ {valorTotal:F2}");
            Console.WriteLine("Obrigado pela compra!");
        }
    }
}
