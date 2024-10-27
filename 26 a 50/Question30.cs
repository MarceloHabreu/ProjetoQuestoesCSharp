using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question30
    {
        // Crie um programa que verifica se uma palavra é um palíndromo.
        public static void DescubraPalidromo()
        {
            Console.WriteLine("---- Questão 30. Crie um programa que verifica se uma palavra é um palíndromo. ----");
            Console.Write("Digite uma palavra para descobrir se ela é um palíndromo:");
            string word = Console.ReadLine();
            Char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string checking = new string(chars);
            if (checking == word)
            {
                Console.WriteLine("A palavra escrita é sim um palídromo, tendo como versão: " + checking + ", a mesma que a original, se lida de trás para frente!");
            } 
            else
            {
                Console.WriteLine("A palavra escrita não é um palídromo, tendo como versão: " + checking + ", diferente da original, se lida de trás para frente!");
            }
        }

        
    }
}
