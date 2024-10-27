using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question50
    {
        // 50. Implemente uma função que calcula o valor de uma potência sem usar Math.Pow().
        public static void CalculaPotencia()
        {
            Console.WriteLine("---- 50. Implemente uma função que calcula o valor de uma potência sem usar Math.Pow()! ----");
            Console.Write("Digite um valor para que possa ser calculado sua potencia:");
            double value = Double.Parse(Console.ReadLine());

            Console.Write("Digite a potência que você deseja que seu número seja elevado:");
            int potencia = int.Parse(Console.ReadLine());

            double result = 1;
            for (int i = 0; i < potencia; i++)
            {
                result *= value; 
            }

            Console.WriteLine($"{value} elevado a potência de {potencia} equivale a: {result:F1}");
        }
    }
}