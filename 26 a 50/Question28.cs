using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{

    internal class Aluno // classe aluno para ser utilizada
    {
        // Crie uma classe Aluno com propriedades Nome e Nota. Implemente um método para exibir esses valores.
        // Atributos
        public string Nome { get; private set; }
        public double Nota { get; private set; }

        // Construtor 
        public Aluno (string nome, double nota)
        {
            this.Nome = nome;
            this.Nota = nota;
        }
        public void ShowInfoAluno() // Metodo para exibir as info
        {
            Console.WriteLine ("----Dados do Aluno----");
            Console.WriteLine($"Nome: {this.Nome}.");
            Console.WriteLine($"Nota: {this.Nota}.");
        }
    }

    internal class Question28 // Class para chamar e executar no Programn menu
    {
        public static void Executar()
        {
            Aluno aluno = new Aluno("Marcelo Henrique", 10);
            aluno.ShowInfoAluno();
        }
    }
}
