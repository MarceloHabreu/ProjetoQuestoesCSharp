using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question20
    {
        // Implemente uma função que calcula a soma dos quadrados dos números de 1 a N.
        public static void SomaQuadradoDosNumeros1aN()
        {
            Console.WriteLine("---- Questão 20. Implemente uma função que calcula a soma dos quadrados dos números de 1 a N. ----");
            Console.Write("Digite um número para que seja feita a soma de todos os quadrados de 1 a até este número: ");
            double numberN = Double.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 1; i <= numberN; i++)
            {
                sum += i*i;
            }
            Console.WriteLine($"A soma do quadrado de todos os números até {numberN} é: {sum}.");
        }
    }
}
