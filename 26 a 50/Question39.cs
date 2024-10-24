using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question39
    {
        // Implemente uma função que calcula o MDC (Máximo Divisor Comum) entre dois números.
        public static void CalcularMDC()
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int mdc = MDC(num1, num2);
            Console.WriteLine($"O Máximo Divisor Comum entre {num1} e {num2} é: {mdc}");
        }
        public static int MDC(int a, int b)
        {
            while (b != 0)
            {
                int divisa = b;
                b = a % b;
                a = divisa;
            }
            return a;
        }
    }
}
