using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question23
    {
        // Crie uma função que retorna o último caractere de uma string fornecida.
        public static void UltimoCaracterString()
        {
            Console.Write("Digite uma string para que seja pego e exibido o seu último caracter: ");
            string word = Console.ReadLine();

            // Conferindo se a string digitada não é vazia ou nula":
            if (!string.IsNullOrEmpty(word) )
            {
                Console.WriteLine($"O último caracter da string '{word}' é '{word[word.Length - 1]}'.");
            }
            else
            {
                Console.WriteLine($"O que você digitou ou é algo vazio ou é nulo!!.");
            }
            
        }
    }
}
