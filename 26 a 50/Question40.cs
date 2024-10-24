using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question40
    {
        // Desenvolva uma função que retorna o número de vogais em uma string.
        public static void ContarVogais()
        {
            Console.Write("Digite algo para que seja feita a contagem das vogais existentes:");
            string input = Console.ReadLine();
            Char[] caracters = input.ToCharArray();

            int countVogais = 0;
            for (int i = 0; i < caracters.Length; i++)
            {
                if (caracters[i] == 'a' || caracters[i] == 'A' ||  caracters[i] == 'e' || caracters[i] == 'E' || caracters[i] == 'i' || caracters[i] == 'I' || caracters[i] == 'o' || caracters[i] == 'O' || caracters[i] == 'u' || caracters[i] == 'U')
                {
                    countVogais++;
                }
            }

            Console.WriteLine($"Existem exatamente {countVogais} vogais na palavra ou frase escrita.");
        }
    }
}
