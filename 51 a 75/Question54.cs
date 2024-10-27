using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._51_a_75
{
    class Question54
    {
        // Implemente uma função que calcula o valor absoluto de um número sem usar Math.Abs().
        public static void CalculaValorAbsoluto()
        {
            Console.WriteLine("---- Questão 54. Implemente uma função que calcula o valor absoluto de um número sem usar Math.Abs().! ----");
            Console.Write("Digite um valor para que seja calculado seu valor absoluto: ");
            int valor = int.Parse(Console.ReadLine());

            int valorAbsoluto;
            if (valor >= 0)
            {
                valorAbsoluto = valor;  // o valor absoluto é exatamente a distancia do número até zero
                Console.WriteLine($"O valor absoluto de {valor} é exatamente {valorAbsoluto}.");
            }
            else if (valor < 0 )
            {
                valorAbsoluto = -valor;   // passando o valor negativo para positivo
                Console.WriteLine($"O valor absoluto de {valor} vale exatamente {valorAbsoluto}.");
            }
        } 
    }
}
