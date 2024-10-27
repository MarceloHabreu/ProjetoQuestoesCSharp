using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question10
    {
        // Implemente uma função que converte temperatura de Celsius para Fahrenheit.
        public static void CelsiusParaFahrenheit()
        {
            Console.WriteLine("---- Questão 10. Implemente uma função que converte temperatura de Celsius para Fahrenheit.! ----");
            Console.Write("Digite uma temperatura em graus celsius para que haja a conversão para Fahrenheit: ");
            double celsius = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{celsius} graus celsius vale aproximadamente: {(celsius * 9/5) + 32} graus Fahrenheit.");  
        }
    }
}
