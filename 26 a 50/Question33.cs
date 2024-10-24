using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question33
    {
        // Desenvolva uma função que retorna a soma dos números ímpares em um array.
        public static void NumerosImparesEmArray()
        {
            Console.Write("Digite a quantidade de números que deseja adicionar ao array:");
            int quantity = int.Parse(Console.ReadLine());
            Double[] numbers = new double[quantity];

            double sumNumbersImpares = 0;
            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Digite o {i + 1}º número:");
                double number = Double.Parse(Console.ReadLine());
                numbers[i] = number;
                if (number%2 != 0)
                {
                    sumNumbersImpares += number; // somando todos os números impares adicionados
                }
            }
            Console.WriteLine($"A soma de todos os números ímpares adicionados no array é: {sumNumbersImpares}.");

        }
    }
}
