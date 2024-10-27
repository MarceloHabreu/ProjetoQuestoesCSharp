using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question45
    {
        // Crie uma função que encontra o segundo maior número em um array.
        public static void SegundoMaiorNoArray()
        {
            Console.WriteLine("---- Questão 45. Crie uma função que encontra o segundo maior número em um array.! ----");
            Console.Write("Digite a quantidade de números que deseja adicionar ao array:");
            int tamanhoArray = int.Parse(Console.ReadLine());
            int[] numbers = new int[tamanhoArray];

            for (int i = 0; i < tamanhoArray; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int primeiroMaior = Math.Max(numbers[0], numbers[1]);  // Definindo o maior valor comparando dois
            int segundoMaior = Math.Min(numbers[0], numbers[1]); // Definindo o menor valor comparando dois

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] > primeiroMaior)
                {
                    segundoMaior = primeiroMaior;   // primeiroMaior passa a ser o segundoMaior
                    primeiroMaior = numbers[i];  // adicionando o maior valor encontrado no primeiroMaior
                }
                else if (numbers[i] > segundoMaior && numbers[i] != primeiroMaior)
                {
                    segundoMaior = numbers[i];  // isso em caso de números não comparados
                }
            }

            Console.WriteLine($"O segundo maior número no array é: {segundoMaior}");
        }
    }
}
