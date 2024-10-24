using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question32
    {
        // Crie uma função que multiplica todos os elementos de um array por um valor fornecido.
        public static void MultiplicaValoresArray()
        {
            Console.Write("Digite a quantidade de números que deseja adicionar ao array:");
            int quantity = int.Parse(Console.ReadLine());
            Double[] numbers = new double[quantity];
            Double[] numbersNew = new double[quantity]; // novo array para adicionar os resultados da multiplicação

            Console.Write("Digite o número pelo qual você deseja multiplicar cada um dos valores a serem adicionados ao array:");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantity; i++)  // loop para adicionar os elementos de acordo com o tamanho que a pessoa digitou
            {
                Console.Write($"Digite o {i + 1}º número:");
                double number = Double.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            for (int i = 0; i < numbers.Length; i++) // loop para multiplicar cada um pelo numero e adicionar em um novo array 
            {
                double result = numbers[i] * value;
                numbersNew[i] = Math.Round(result, 2); // fazendo com que cada multiplicação, caso tenha número decimal, tenha apenas 2.

            }

            string numbersString = string.Join(",", numbers); // utilizando um metodo string para que cada elemento do array seja exibido um após o outro e separados por virgula.
            string numbersStringNew = string.Join(",", numbersNew);
            Console.WriteLine($"Valores adicionados ao array[{numbersString}] e ao serem multiplicados cada um por {value}, esses são seus novos valores: [{numbersStringNew}].");

        }
    }
}
