using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question42
    {
        // Implemente uma função que recebe um número e exibe sua representação em palavras.
        public static void NumeroParaPalavras()
        {
            Console.WriteLine("---- Questão 42. Implemente uma função que recebe um número e exibe sua representação em palavras.! ----");
            Console.Write("Digite um número para que seja convertido para palavras (max=99): ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0 || numero > 99)
            {
                Console.WriteLine("O número está fora do intervalo!");
                return;
            }

            string[] unidades = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
            string[] especiais = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezenas = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };

            if (numero < 10)
            {
                Console.WriteLine(unidades[numero]);
            }
            else if (numero < 20)
            {
                Console.WriteLine(especiais[numero - 10]);
            }
            else
            {
                int dezena = numero / 10;
                int unidade = numero % 10;

                if (unidade == 0)
                {
                    Console.WriteLine(dezenas[dezena]);
                }
                else
                {
                    Console.WriteLine($"{dezenas[dezena]} e {unidades[unidade]}");
                }
            }
        }
    }
}