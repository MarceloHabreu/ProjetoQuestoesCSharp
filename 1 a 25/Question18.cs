using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question18
    {
        // Escreva uma função que conta quantas letras 'a' existem em uma string.
        public static void BuscaLetraA()
        {
            Console.WriteLine("---- Questão 18. Escreva uma função que conta quantas letras 'a' existem em uma string. ----");
            Console.Write("Digite uma palavra para que haja a contagem de quantas letras 'a' existem nesta palavra: ");
            string word = Console.ReadLine();
            

            Console.WriteLine($"Na palavra '{word}' exitem exatamente: {countLetter(word)} letras 'a'.");
        }

        public static int countLetter(string word) // função auxiliar para o BuscaLetraA
        {
            Char[] chars = word.ToCharArray(); // Transformando a string em um array
            int quantity = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'a' || chars[i] == 'A')
                {
                    quantity++;
                }
            }
            return quantity;
        }
    }
}
