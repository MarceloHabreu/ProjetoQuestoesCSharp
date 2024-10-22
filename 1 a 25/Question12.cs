using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question12
    {
        // Crie uma função que exibe todos os números pares entre 1 e 50.
        public static void Pares_1a50()
        {
            Console.WriteLine("--- Números pares de 1 a 50 ---");
            for (int i = 0; i <= 50; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
           
        }
    }
}
