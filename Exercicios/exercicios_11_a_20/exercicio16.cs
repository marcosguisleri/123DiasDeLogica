using System;

namespace _123_dias_logica.Exercicios.Exercicios_11_a_20
{
    public class Exercicio16
    {
        public static void Executar()
        {
            // Exercício 16.
            Console.WriteLine("Exercício 16: Crie um algoritmo para calcular o salário liquido de um funcionário, considerando que seu salário bruto incide um desconto de 8,5% de INSS para a previdência. O algoritmo deve mostrar o nome do funcionário, o seu salário bruto, o valor de desconto de INSS e o seu salário liquido. (Dica: você deve pedir (ler) o nome do funcionário e o valor do seu salário bruto). \n");

            // Lógica do exercício 16
            Console.WriteLine("Informe o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o salário bruto do funcionário: ");
            double salarioBruto = Convert.ToDouble(Console.ReadLine());

            double salarioDescontado = salarioBruto * 0.085;
            double salarioLiquido = salarioBruto - salarioDescontado;

            Console.WriteLine($"O funcionário {nome} recebe um desconto de R${salarioDescontado:f2} ficando assim com o salário líquido de R${salarioLiquido:f2}");
        }
    }
}
