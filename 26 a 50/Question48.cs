using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question48
    {
        // Desenvolva uma função que recebe uma data e exibe o dia da semana correspondente.
        public static void ExibeDiaSemana()
        {
            Console.Write("Digite uma data (dd/MM/yyyy): ");
            string dataEscrita = Console.ReadLine();
            DateTime data;  // classe DateTime nativa do c#

            if (DateTime.TryParseExact(dataEscrita, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))  // Tentando converter a data escrite para a para uma data no formato dd/MM/yyyy e assim descobrir o dia da semana
            {
                Console.WriteLine($"A data {data.ToString("dd/MM/yyyy")} é um dia de {data.DayOfWeek}.");
            }
            else
            {
                Console.WriteLine("Data inválida! Tente Novamente...");
            }
           

        }
    }
}
