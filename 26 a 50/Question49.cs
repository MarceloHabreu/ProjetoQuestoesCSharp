using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question49
    {
        // Crie um programa que verifica se uma string contém apenas letras e números.
        public static void VerificaString()
        {
            Console.WriteLine("---- Questão 49. Crie um programa que verifica se uma string contém apenas letras e números! ----");
            Console.Write("Digite algo para ser verificado:"); 
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"))   // utilizando a classe regex do c# para que possa fazeer a validação dos caracters, ela nos permite fazer verificar expressões regulares!
            {
                // Verifica se a string contém apenas letras
                if (Regex.IsMatch(input, @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine($"Há apenas letras em {input}.");
                }
                // Verifica se a string contém apenas números
                else if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    Console.WriteLine($"Há apenas números em {input}.");
                }
                else
                {
                    Console.WriteLine($"Há apenas letras e números em {input}.");
                }
            }
            else
            {
                Console.WriteLine($"Não há letras e números em {input}.");
            }
        }
    }
}
