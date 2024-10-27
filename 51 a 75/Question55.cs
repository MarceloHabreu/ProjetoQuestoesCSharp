using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._51_a_75
{
    internal class Question55
    {
        // Crie um programa que implementa o algoritmo de busca linear.
        public static void AlgoritmoDeBuscaLinear()
        {
            Console.WriteLine("---- Questão 55. Crie um programa que implementa o algoritmo de busca linear.! ----");
            Console.Write("Digite quanto itens deseja adicionar a sua lista: ");
            int quantity = int.Parse(Console.ReadLine());

            List<string> itens = new List<string>();
            for (int i = 0; i < quantity; i++) 
            {
                Console.Write($"Digite o {i + 1}º item que deseja adicionar a lista: ");
                string item = Console.ReadLine();
                itens.Add(item);
            }

            Console.Write($"Digite qual item adicionado a lista você deseja buscar de forma linear: ");
            string itemBusca = Console.ReadLine();

            for (int i = 0; i < itens.Count ; i++)
            {
                if (itens[i] != itemBusca)
                {
                    Console.WriteLine($"Passando pelo {i +1}º item da lista: {itens[i]}. Elemento ainda não incontrado...");
                }
                else
                {
                    Console.WriteLine ($"Passando pelo {i + 1}º item da lista: {itens[i]}. Elemento encontrado com sucesso!!!");
                    break;
                }
            }
        }
    }
}
