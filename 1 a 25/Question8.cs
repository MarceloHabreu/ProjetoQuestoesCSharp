using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question8
    {
        // Crie um programa que exibe a tabuada de um número fornecido.
        public static void Tabuada()
        {
            Console.WriteLine("---- Questão 8. Crie um programa que exibe a tabuada de um número fornecido.! ----");
            Console.Write("Digite um número para que seja fornecido sua tabuada completa: ");
            double number = Double.Parse(Console.ReadLine());
            Console.WriteLine($"----Tabuada do {number}----");
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
    }
}
