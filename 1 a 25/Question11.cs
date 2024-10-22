using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question11
    {
        // Crie uma função que verifica se uma string é vazia ou nula.
        public static void StringVaziaOrNula()
        {
            Console.Write("Teste para string vazia ou nula: ");
            string stringCheck = Console.ReadLine();

            if (string.IsNullOrEmpty(stringCheck))   // Usando uma funçao da classe string nativa do c# para a verificaçao da string!
            {
                Console.WriteLine("String é vazia ou nula!");
            } 
            else
            {
                Console.WriteLine("String não é vazia ou nula!");
            }
        }
    }
}
