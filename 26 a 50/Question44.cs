using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question44
    {
        // Desenvolva uma função que calcula o IMC e determina a categoria (baixo peso, normal, etc.).
        public static void CalculaIMC()
        {
            Console.WriteLine("---- Questão 44. Desenvolva uma função que calcula o IMC e determina a categoria (baixo peso, normal, etc.).! ----");
            Console.Write("Digite seu nome:");
            string name = Console.ReadLine();
            Console.Write("Digite seu peso em kg:");
            double weight = double.Parse(Console.ReadLine());
            Console.Write("Digite sua altura em metros:");
            double height = double.Parse(Console.ReadLine());

            double imc = weight / (height * height);

            if (imc < 18.5)
            {
                Console.WriteLine($"{name}, seu IMC é de {imc:F2}. Você está abaixo do peso!");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine($"{name}, muito bem! Seu IMC é de {imc:F2}. Você está com o peso normal.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine($"{name}, seu IMC é de {imc:F2}. Você está com sobrepeso!");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine($"{name}, seu IMC é de {imc:F2}. Você está com obesidade grau I. CUIDE-SE!");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine($"{name}, seu IMC é de {imc:F2}. Você está com obesidade grau II. CUIDE-SE IMEDIATAMENTE!");
            }
            else if (imc >= 40)
            {
                Console.WriteLine($"{name}, seu IMC é de {imc:F2}. Você está com obesidade grau III. CUIDE-SE IMEDIATAMENTE!!");
            }
        }
    }
}
