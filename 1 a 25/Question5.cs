using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question5
    {
        // Implemente um método que converte um valor em metros para centímetros.
        public static void ConversorCentimetros()
        {
            Console.Write("Digite o valor em metros para converter para centímetros: ");
            double metros = double.Parse(Console.ReadLine());

            Console.Write($"{metros} metros são: {metros * 100} centrimetos.\n");
        }
    }
}
