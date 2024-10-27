using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question6
    {
        // Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.
        public static void VerificadorIdade()
        {
            Console.WriteLine("---- Questão 6. Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.! ----");
            Console.Write("Digite uma idade: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 0 || age > 200)
            {
                Console.Write("Idade inválida!\n");
            }
            else if (age >= 18)
            {
                Console.Write($"{age} é maior de idade!\n");
            }
            else
            {
                Console.Write($"{age} não é maior de idade!\n");
            }
        }
    }
}
