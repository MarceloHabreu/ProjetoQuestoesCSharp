using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question17
    {
        // Implemente um programa que calcula a média de três notas e exibe a situação (Aprovado/Reprovado).
        public static void MediaNotas()
        {
            List<Double> notas = new List<double>();  // reutilizando a estrutura da questão 13

            Console.Write("Digite a primeira nota: ");
            double firstNumber = Double.Parse(Console.ReadLine());
            notas.Add(firstNumber);

            Console.Write("Digite a segunda nota: ");
            double secondNumber = Double.Parse(Console.ReadLine());
            notas.Add(secondNumber);

            Console.Write("Digite a terceira nota: ");
            double thirdNumber = Double.Parse(Console.ReadLine());
            notas.Add(thirdNumber);

            // Fazendo a media e descobrindo a situação
            double somaGeral = 0;
            for (int i = 0; i < notas.Count; i++)
            {
                somaGeral += notas[i];
            }

            if (somaGeral/3 > 6)
            {
                Console.WriteLine($"Com estas notas sua média final é {(somaGeral / 3):F2} e fica com a situação de aprovado!!"); // Utilziando este F2 para formatar a saída. Sair com 2 casas decimais apenas!!
            }
            else
            {
                Console.WriteLine($"Com estas notas sua média final é {(somaGeral / 3):F2} e fica com a situação de reprovado!!");
            }
        }
    }
}
