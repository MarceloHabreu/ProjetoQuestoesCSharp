using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question31
    {
        // Implemente uma função que encontra o menor número em um array.
        public static void MenorNumeroArray()
        {
            Console.WriteLine("---- Questão 31. Implemente uma função que encontra o menor número em um array. ----");
            Console.Write("Digite a quantidade de números que deseja adicionar ao array:");
            int quantity = int.Parse(Console.ReadLine()); 
            Double[] numbers = new double[quantity]; 

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Digite o {i + 1}º número:");
                double number = Double.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            double smaller = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smaller)
                {
                    smaller = numbers[i];
                }
            }
            Console.WriteLine($"O menor número adicionado ao array de números é: {smaller}");

        }
    }
}
