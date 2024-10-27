using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question22
    {
        // Escreva um programa que recebe um número e exibe seu dobro e triplo.
        public static void DobroETriplo()
        {
            Console.WriteLine("---- Questão 22. Escreva um programa que recebe um número e exibe seu dobro e triplo. ----");
            Console.Write("Digite um número para que seja exebido seu dobro e seu triplo: ");
            double number = Double.Parse(Console.ReadLine());

            Console.WriteLine($"O dobro de {number} é {number*2} e o seu triplo é {number*3}.");
        }
    }
}
