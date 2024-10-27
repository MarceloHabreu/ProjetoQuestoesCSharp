using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question7
    {
        // Escreva um método que calcula a área de um círculo com base no raio fornecido.
        public static void CalculaAreaCirculo()
        {
            Console.WriteLine("---- Questão 7. Escreva um método que calcula a área de um círculo com base no raio fornecido.! ----");
            Console.Write("Digite o valor do raio para calcular a área do circulo: ");
            double raio = double.Parse(Console.ReadLine());
            double area = Math.Round(raio * raio * 3.14, 2);
            Console.Write($"Com o raio medindo {raio}, a área do circulo valeria: {area}\n.");
        }
    }
}
