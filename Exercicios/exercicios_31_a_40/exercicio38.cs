using System;

namespace _123_dias_logica.Exercicios.Exercicios_31_a_40
{
    public class Exercicio38
    {
        public static void Executar()
        {
            // Exercício 38.
            Console.WriteLine("Exercício 38: Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo, conforme a tabela abaixo. Faça um algoritmo que leia o salário e o cargo de um funcionário e calcule o novo salário. Se o cargo do funcionário não estiver na tabela, ele deverá, então, receber 40% de aumento. Mostre o salário antigo, o novo salário e a diferença. \n");

            // Lógica do exercício 38
            Console.WriteLine("Informe o salário do funcionário: ");
            double salarioFuncionario = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Informe o cargo do funcionário: ");
            string cargoFuncionario = Console.ReadLine();

            double newSalario = 0;

            switch(cargoFuncionario)
            {
                case "Gerente":
                    newSalario = salarioFuncionario * 0.10 + salarioFuncionario;
                    Console.WriteLine($"O salário antigo é R$ {salarioFuncionario} o novo salário com reajuste de 10% é R$ {newSalario} ");
                    break;
                case "Engenheiro":
                    newSalario = salarioFuncionario * 0.20 + salarioFuncionario;
                    Console.WriteLine($"O salário antigo é R$ {salarioFuncionario} o novo salário com reajuste de 20% é R$ {newSalario} ");
                    break;
                case "Tecnico":
                    newSalario = salarioFuncionario * 0.30 + salarioFuncionario;
                    Console.WriteLine($"O salário antigo é R$ {salarioFuncionario} o novo salário com reajuste de 30% é R$ {newSalario} ");
                    break;
                default:
                    newSalario = salarioFuncionario * 0.40 + salarioFuncionario;
                    Console.WriteLine($"O salário antigo é R$ {salarioFuncionario} o novo salário com reajuste de 40% é R$ {newSalario} ");
                    break;           
            }
        }
    }
}
