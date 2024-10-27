using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Question21
    {
        // Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas vindas
        public static void BoasVindas()
        {
            Console.WriteLine("---- Questão 21. Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas-vindas. ----");
            Console.Write("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seja bem muito bem vindo {name}, com seus {idade} anos irá se divertir bastante em meu sistema soluçao das 100 questões de POO!!");
        }
    }
}
