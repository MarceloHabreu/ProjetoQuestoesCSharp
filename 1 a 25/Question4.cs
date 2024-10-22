using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question4
    {
        // Escreva uma função que verifica se um número é par ou ímpar.
        public static void ParOrImpar()
        {
            Console.Write("Digite um número para verificar se o número é par ou impar: ");
            double number = Double.Parse(Console.ReadLine());

            if (number%2 == 0 )
            {
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("O número é impar!");
            }
        }
    }
}
