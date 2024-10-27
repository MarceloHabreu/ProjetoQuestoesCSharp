using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question29
    {
        // Implemente um método que calcula a média de uma lista de números.
        public static void MediaListaNumeros()
        {
            List<double> numbers = new List<double>();
            Console.WriteLine("---- Questão 29. Implemente um método que calcula a média de uma lista de números. ----");

            Console.Write("Digite a quantidade de números que deseja adicionar em uma lista para calcular sua média:");
            int quantity = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantity; i++)
            {
                Console.Write($"Digite o {i+1}º número:");
                double number = Double.Parse(Console.ReadLine());
                numbers.Add(number);
            }
            double average = numbers.Average();
            Console.WriteLine($"A média de todos os números adicionados a lista é: {average:F2}");
        }
    }
}
