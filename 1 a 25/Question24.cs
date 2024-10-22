using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question24
    {
        // Implemente uma função que converte horas em segundos.
        public static void HorasEmSegundps()
        {
            Console.Write("Digite um valor em horas para que seja convertido em segundos:");
            double hours = Double.Parse(Console.ReadLine());

            Console.WriteLine($"{hours} horas em segundos são exatamente: {hours * 3600} segundos.");

        }
    }
}
