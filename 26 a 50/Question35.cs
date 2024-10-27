using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question35
    {
        // Implemente um método para verificar se um ano é bissexto.
        public static void DescobreAnoBissexto()
        {
            Console.WriteLine("---- Questão 35. Implemente um método para verificar se um ano é bissexto. ----");
            Console.Write("Digite um ano para saber se ele é bissexto:");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine($"O ano {ano} é sim um ano bissexto!");
            }
            else
            {
                Console.WriteLine($"O ano {ano} não é um ano bissexto!");
            }
        }
    }
}
