using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question26
    {
        public static void Ordena3Numeros()
        {
            // Crie uma função que ordena três números fornecidos.
            Console.WriteLine("---- Questão 26. Crie uma função que ordena três números fornecidos. ----");
            List<Double> numbers = new List<double>();

            Console.Write("Digite o primeiro número:");
            double numberOne = Double.Parse(Console.ReadLine());
            numbers.Add(numberOne);

            Console.Write("Digite o segundo número:");
            double numberTwo = Double.Parse(Console.ReadLine());
            numbers.Add(numberTwo);

            Console.Write("Digite o terceiro número:");
            double numberThree = Double.Parse(Console.ReadLine());
            numbers.Add(numberThree);

            numbers.Sort();

            Console.WriteLine($"Os números {numberOne}, {numberTwo} e {numberThree} ordenados ficam:");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
