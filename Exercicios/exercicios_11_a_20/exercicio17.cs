using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio17
    {
        public static void Executar()
        {
            // Exercício 17.
            Console.WriteLine("Exercício 17: Considerando que para um consórcio sabe-se o numero total de prestações, a quantidade de prestações pagas e o valor atual da prestação. Escreva um algoritmo que determine o total pago pelo consorciado e o saldo devedor. \n");

            // Lógica do exercício 17
            Console.WriteLine("Informe a quantidade de parcelas: ");
            int quantParcelas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de prestações paga: ");
            int quantPagas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Qual o valor atual da prestação? em R$ ");
            double valorParcela = Convert.ToDouble(Console.ReadLine());

            double totalPago = quantPagas * valorParcela;
            double saldoDevedor = (valorParcela * quantParcelas) - totalPago;

            Console.WriteLine($"O total pago pelo consorciado é R${totalPago} e seu saldo devedor é R${saldoDevedor} ");
        
        }
    }
}
