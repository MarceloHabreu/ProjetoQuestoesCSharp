using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._51_a_75
{
    internal class Question52
    {
        // Desenvolva um programa que ordena uma lista de nomes em ordem alfabética.
        public static void OrdernaNomes()
        {
            Console.WriteLine("---- Questão 52. Desenvolva um programa que ordena uma lista de nomes em ordem alfabética.! ----");
            Console.Write("Quantos nomes você deseja adicionar para ordena-los?");
            int quantity = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Digite o {i + 1}º nome: ");
                string name = Console.ReadLine();
                names.Add(name);
            }

            names.Sort();
            string namesSorted = string.Join(",", names);
            Console.WriteLine($"Os nomes ordernados de forma alfabética: [{namesSorted}]");

        }
    }
}
