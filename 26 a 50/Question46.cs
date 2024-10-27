using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question46
    {
        // Implemente um programa que inverte os elementos de um array.
        public static void InverteElementosArray()
        {
            Console.WriteLine("---- Questão 46. Implemente um programa que inverte os elementos de um array.! ----");
            Console.Write("Digite a quantidade de números que deseja adicionar ao array:");
            int tamanhoArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[tamanhoArray];

            for (int i = 0; i < numbers.Length; i++)
            {

                Console.Write($"Digite o {i + 1}º número: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Reverse(numbers);
            string numbersToString = string.Join(",", numbers);
            Console.WriteLine($"O array com os elemenmtos invertidos: [{numbersToString}].");
        }
    }
}
