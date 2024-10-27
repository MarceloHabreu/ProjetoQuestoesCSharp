using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question43
    {
        // Crie um programa que simula o lançamento de um dado 100 vezes e exibe a frequência de cada valor.
        public static void LancamentoDado()
        {
            Console.WriteLine("---- Questão 43. Crie um programa que simula o lançamento de um dado 100 vezes e exibe a frequência de cada valor.! ----");
            Console.Write("Deseja iniciar o lançamento do dado 100 vezes e saber a frequência de cada resultado? (y/n):");
            string response = Console.ReadLine();

            List<int> valoresDado = new List<int>{ 1,2,3,4,5,6};
            Random random = new Random();  /// iniciando a classe ramdom para gerar um indice aleatorio
            Dictionary<int, int> frequencias = new Dictionary<int, int> {{ 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }};  // Armazennando no dictionary conjunto de chaves valores para iniciar a frequência de cada valor como 0.

            if (response == "y")
            {
                Console.WriteLine("100 lançamentos do dado: ");
                for (int i = 0; i < 100; i++)
                {
                    int indice = random.Next(valoresDado.Count);
                    int valor = valoresDado[indice];
                    frequencias[valor]++;
                    Console.WriteLine($"{i + 1}º lançamento saiu o valor = " + valor);
                }

                Console.WriteLine("\nFrequência de cada valor:");
                foreach (var freq in frequencias)
                {
                    Console.WriteLine($"Valor {freq.Key}: {freq.Value} vezes");
                }
            }
            else
            {
                Console.WriteLine("Qunado desejar lançar o dado apenas volte a essa questão!");
            }
        }
    }
}
