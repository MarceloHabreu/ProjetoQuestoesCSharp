using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question41
    {
        // Crie uma função que converte um número decimal para binário.
        public static void DecimalParaBinario()
        {
            Console.Write("Digite um número decimal para que seja convertido para binário:");
            int decimalNumber = int.Parse(Console.ReadLine());
            int originalDecimal = decimalNumber;    // armazenando o número escrito para exibi-lo

            List<int> binarios = new List<int>();    
            while (decimalNumber > 0)
            {
                int result = decimalNumber % 2;  // armazendo o valor de cada resto
                binarios.Add(result); // adicionando cada resto a uma lista de numeros
                decimalNumber = decimalNumber / 2;  // dividindo o quociente até zerar 
            }

            binarios.Reverse();
            string numberBinario = string.Join("", binarios);

            Console.WriteLine($"O número {originalDecimal} convertido para binário vale: {numberBinario}.");
        }
    }
}
