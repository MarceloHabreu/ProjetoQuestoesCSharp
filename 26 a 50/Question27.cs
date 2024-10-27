using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question27
    {
        public static void Fatorial()
        {
            // Desenvolva um programa que calcula o fatorial de um número.
            Console.WriteLine("---- Questão 27. Desenvolva um programa que calcula o fatorial de um número. ----");
            Console.Write("Digite um número para que seja calculado sua fatorial:");
            int number = int.Parse(Console.ReadLine());
            long fatorial = 1;
            for (int i = 1; i <= number; i++)
            {
                fatorial = fatorial * i;
            }
            

            Console.WriteLine($"A fatorial do número {number} é: {fatorial}");
            
        }
    }
}
