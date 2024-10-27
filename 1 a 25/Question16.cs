using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question16
    {
        // Crie uma função que verifica se um número é positivo ou negativo.
        public static void PositivoOrNegativo()
        {
            Console.WriteLine("---- Questão 16. Crie uma função que verifica se um número é positivo ou negativo. ----");
            Console.Write("Digite um número para sua verificação de positivo ou negativo: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"O número {number} é positivo!");
            }
            else
            {
                Console.WriteLine($"O número {number} é negativo!");
            }
        }
    }
}
