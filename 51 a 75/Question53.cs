using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._51_a_75
{
    internal class Question53
    {
        // Crie uma função que encontra o elemento mais frequente em um array.
        public static void BuscaFrequenciaArray()
        {
            Console.WriteLine("---- Questão 53. Crie uma função que encontra o elemento mais frequente em um array! ----");
            Console.Write("Quantos números você deseja adicionar para que ocorra a verificação da frequência: ");
            int quantity = int.Parse(Console.ReadLine());
            int[] numbers = new int[quantity];
             
            
            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Digite o {i + 1}º numero: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var frequencia = new Dictionary<int, int>();   // utilizando do dictionary conjunto chave valor para fazer a contagem
            // Contagem de frequências
            foreach (int number in numbers)
            {
                if (frequencia.ContainsKey(number))
                {
                    frequencia[number]++;
                }
                else
                {
                    frequencia[number] = 1;
                }
            }

            int maisFrequente = numbers[0];    // inicialia a contagem apra o numero mais frequente
            int maiorContagem = frequencia[maisFrequente];     // inicializa a contagem maxima

            foreach (var f in frequencia)
            {
                if (f.Value > maiorContagem)
                {
                    maisFrequente = f.Key;  // colocando o mais frequente 
                    maiorContagem = f.Value;  // colocando a quantidade de vezes que ele apareceu
                }
            }

            Console.WriteLine($"O número mais frequente do array foi o {maisFrequente}, com um total de {maiorContagem} frequencias");
        }

    }
}
