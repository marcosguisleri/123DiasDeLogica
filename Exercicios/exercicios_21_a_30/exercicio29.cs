using System;

namespace _123_dias_logica.Exercicios.Exercicios_21_a_30
{
    public class Exercicio29
    {
        public static void Executar()
        {
            // Exercício 29.
            Console.WriteLine("Exercício 29: Elabore um algoritmo que dada a idade de um nadador classifique-o em uma das seguintes categorias: \n");

            // Lógica do exercício 29
            int idade;

            Console.Write("Informe a idade do nadador: ");
            while (!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.Write("Entrada inválida! Digite uma idade válida (maior que 0): ");
            }

            if(idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Categoria: Infantil A ");
            }
            else if(idade  >= 8 && idade <= 10)
            {
                Console.WriteLine("Categoria: Infantil B ");
            }
            else if(idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Categoria: Juvenil A ");
            }
            else if(idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Categoria: Juvenil B ");
            }
            else if(idade >= 18)
            {
                Console.WriteLine("Categoria: Adulto ");
            }
            else 
            {
                Console.WriteLine("Nenhuma categoria! ");
            }
            
        }
    }
}
