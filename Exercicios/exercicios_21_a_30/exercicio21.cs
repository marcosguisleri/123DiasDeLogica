using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio21
    {
        public static void Executar()
        {
            // Exercício 21.
            Console.WriteLine("Exercício 21: A padaria PÃOQUENTE vende uma certa quantidade de pães franceses e uma quantidade de broas todo dia. Cada pãozinho custa R$ 0,35 e a broa custa R$ 1,50. Ao final do dia, o dono quer saber quanto arrecadou com a venda dos pães e broas (juntos), e quanto deve guardar numa conta de poupança (10% do total arrecadado). Você foi contratado para fazer os cálculos para o dono. Com base nesses fatos, faça um algoritmo para ler as quantidades de pães e broas, e depois calcule e mostre os dados solicitados. \n");

            // Lógica do exercício 21
            Console.WriteLine("Informe a quantidade de pães vendidos: ");
            int quantPao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade broas vendidads: ");
            int quantBroas = Convert.ToInt32(Console.ReadLine());

            double vendaTotal = (quantBroas * 1.50) + (quantPao * 0.35);
            double valorPoupanca = vendaTotal * 0.10;

            Console.WriteLine($"O valor total de venda dos produtos é R${vendaTotal:f2} e deve ser guardado R${valorPoupanca:f2} na poupança. ");
        }
    }
}
