using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question13
    {
        // Implemente uma função que recebe três números e retorna o maior deles.
        public static void MaiorDos3()
        {
            Console.WriteLine("---- Questão 13. Implemente uma função que recebe três números e retorna o maior deles.! ----");
            List<Double> numbers = new List<double>();   // Criando uma lista para adicionar os números para que possa compara-los usando um for

            Console.Write("Digite o primeiro número: ");
            double firstNumber = Double.Parse(Console.ReadLine());
            numbers.Add(firstNumber);

            Console.Write("Digite o segundo número: ");
            double secondNumber = Double.Parse(Console.ReadLine());
            numbers.Add(secondNumber);

            Console.Write("Digite o terceiro número: ");
            double thirdNumber = Double.Parse(Console.ReadLine());
            numbers.Add(thirdNumber);

            double greater = numbers[0];  // inicializando o greater com o primeiro da lista para fazer as comparações!
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > greater)
                {
                    greater = numbers[i];
                }
            }
            Console.WriteLine($"O maior entre eles é o {greater}!");
        }
    }
}
