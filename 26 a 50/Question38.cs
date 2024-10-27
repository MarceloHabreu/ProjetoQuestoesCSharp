using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question38
    {
        // Crie uma função que retorna o índice do maior elemento de um array.
        public static void IndiceMaiorElemArray()
        {
            {
                Console.WriteLine("---- Questão 38. Crie uma função que retorna o índice do maior elemento de um array. ----");
                Console.Write("Digite a quantidade de números que deseja adicionar ao array:");
                int quantity = int.Parse(Console.ReadLine());
                Double[] numbers = new double[quantity];

                for (int i = 0; i < quantity; i++)
                {
                    Console.Write($"Digite o {i + 1}º número:");
                    double number = Double.Parse(Console.ReadLine());
                    numbers[i] = number;
                }

                double maior = numbers[0];
                int indiceMaior = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > maior)
                    {
                        maior = numbers[i];
                        indiceMaior = i;

                    }
                }
                Console.WriteLine($"O indice do maior elemento adicionado no array: {indiceMaior}");

            }
        }
    }
}
