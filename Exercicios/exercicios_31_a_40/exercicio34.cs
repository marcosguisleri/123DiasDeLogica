using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio34
    {
        public static void Executar()
        {
            // Exercício 34.
            Console.WriteLine("Exercício 34: Um banco concederá um crédito especial aos seus clientes, variável com o saldo médio no último ano. Faça um algoritmo que leia o saldo médio de um cliente e calcule o valor do crédito de acordo com a tabela abaixo. Mostre uma mensagem informando o saldo médio e o valor do crédito. (use o comando escolha-caso e não faça repetições) \n");

            // Lógica do exercício 34
            Console.WriteLine("Informe o saldo médio do último ano: ");
            double saldoMedio = Convert.ToDouble(Console.ReadLine());   

            double valorCredito = 0;

            if(saldoMedio >= 0 && saldoMedio <= 200)
            {
                Console.WriteLine("Nenhum crédito ");
            }
            else if(saldoMedio >= 201 && saldoMedio <= 400)
            {
                valorCredito = saldoMedio * 0.20;
                Console.WriteLine($"Valor do crédito: R$ {valorCredito:f2}");
                Console.WriteLine("20% do valor do saldo médio ");
            }
            else if(saldoMedio >= 401 && saldoMedio <= 600)
            {
                valorCredito = saldoMedio * 0.30;
                Console.WriteLine($"Valor do crédito: R$ {valorCredito:f2}");
                Console.WriteLine("30% do valor do saldo médio ");
            }
            else
            {   
                valorCredito = saldoMedio * 0.40;
                Console.WriteLine($"Valor do crédito: R$ {valorCredito:f2}");
                Console.WriteLine("40% do valor do saldo médio ");
            }

        }
    }
}
