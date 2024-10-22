using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question14
    {
        // Crie um programa que inverte uma string.
        public static void InverteString()
        {
            Console.Write("Escreva uma string para que seja invertida: ");
            string word = Console.ReadLine();

            Console.WriteLine($"A string invertida é {ReverseString(word)}.");
        }

        public static string ReverseString(string word)
        {
            Char[] chars = word.ToCharArray();   // Criando um array de caracteres com a string (cada letra).
            Array.Reverse(chars);  // Revertendo esse array
            return new string(chars); // Transformando o array invertido novamente em uma string
        }
    }
}
