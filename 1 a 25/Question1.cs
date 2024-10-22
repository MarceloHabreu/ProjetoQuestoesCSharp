using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_25
{
    internal class Produto
    {
        // Crie uma classe Produto com propriedades Nome e Preco.
        // atributos
        public string Nome { get; private set; }
        public double Preco  { get; private set; }

        // Construtor
        public Produto(string nome, double preco)
        {
            this.Nome = nome;
            this.Preco = preco;
        }

        public void showInfosProduto()
        {
            Console.WriteLine($"Nome: ${Nome}, Preço: ${Preco}");
        }

    }

    internal class Question1
    {
        public static void Executar() // Método para executar a questão
        {
            Produto produto1 = new Produto("PS5", 3700.99); // Para não ficar vazio, inicializei um produto nesta questao também!
            produto1.showInfosProduto();
        }
    }
}
