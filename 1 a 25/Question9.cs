using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question9
    {
        // Desenvolva um método que soma todos os números de 1 a N.
        public static void SomaNumeros1aN()
        {
            Console.WriteLine("---- Questão 9. Desenvolva um método que soma todos os números de 1 a N.! ----");
            Console.Write("Digite um número para que possa ser feito a soma de todos os número de 1 a ele: ");
            double numberN = Double.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 1; i <= numberN; i++)
            {
                sum += i;
            }
            Console.WriteLine($"A soma de todos os números até {numberN} é {sum}");
        }
    }
}
