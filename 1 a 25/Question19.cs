using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question19
    {
        // Crie um programa que imprime números de 1 a 10 em ordem decrescente.
        public static void NumerosDecrescente1_10()
        {
            Console.WriteLine("---- Questão 19. Crie um programa que imprime números de 1 a 10 em ordem decrescente. ----");
            List<int> numbers = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine("Sequencia de 1 a 10 de forma decrescente: ");
            numbers.Reverse();
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        
    }
}
