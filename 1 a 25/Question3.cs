using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_100
{
    internal class Question3
    {
        // Crie um método que soma dois números inteiros e exibe o resultado.
        public static void Soma()
        {
            Console.Write("Digite um numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"A soma entre os números é: {a + b}. \n");
        }
    }
}
