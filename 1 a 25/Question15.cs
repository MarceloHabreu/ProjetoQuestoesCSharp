using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question15
    {
        // Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento.
        public static void Votar()
        {
            Console.WriteLine("---- Questão 15. Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento. ----");
            Console.Write("Digite o ano de nascimento: "); 
            int yearBirth = int.Parse(Console.ReadLine());

            if (2024 - yearBirth > 15)
            {
                Console.WriteLine("Você tem idade para votar!!");
            }
            else
            {
                Console.WriteLine("Você não tem idade para votar!!");
            }
        }
    }
}
