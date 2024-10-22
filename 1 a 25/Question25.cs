using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question25
    {
        // Crie uma função que verifica se um número é divisível por 3 e por 5.
        public static void DivisivelPor3e5()
        {
            Console.Write("Digite um valor para verificar se ele é divisivel por 3 e por 5:");
            double value = Double.Parse(Console.ReadLine());

            if (value%3 == 0 && value%5 == 0)
            {
                Console.WriteLine($"O número {value} é sim um divisor de 3 e 5.");
            }
            else
            {
                Console.WriteLine($"O número {value} não é um divisor de 3 e 5.");
            }

        }
    }
}
