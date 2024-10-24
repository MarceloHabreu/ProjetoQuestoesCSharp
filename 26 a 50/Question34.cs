using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Carro
    {
        // Crie uma classe Carro com propriedades Marca e Ano.
        // Atributos
        public string Marca { get; private set; }
        public int Ano { get; private set; }

        // Construtor 
        public Carro(string marca, int ano)
        {
            this.Marca = marca;
            this.Ano = ano;
        }
        public void showInfoCarro() // Metodo para exibir as info
        {
            Console.WriteLine("----Dados do Carro----");
            Console.WriteLine($"Marca: {this.Marca}.");
            Console.WriteLine($"Ano: {this.Ano}.");
        }
    }

    internal class Question34 // Class para chamar e executar no Programn menu
    {
        public static void Executar()
        {
            Carro carro = new Carro("Toyota", 2021);
            carro.showInfoCarro();
        }
    }
}

