using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question37
    {
        // Desenvolva um programa que recebe uma string e substitui todos os espaços por '_'
        public static void SubstituiString()
        {
            Console.Write("Digite Uma frase qualquer: ");
            string phrase = Console.ReadLine();

            string phraseAlter = phrase.Replace(" ", "_");

            Console.WriteLine($"Frase alterada, onde todos os espaços foram trocados por '_': {phraseAlter}.");
        }
    }
}
