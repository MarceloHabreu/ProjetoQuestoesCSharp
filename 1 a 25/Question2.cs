﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._1_a_100
{
    internal class Question2
    {
        // Instancie um objeto da classe Produto e exiba seus valores.
        public static void Executar()  // criando um metodo para executar a questão
        {
            Produto produto2 = new Produto("PS4", 2229.00);
            produto2.showInfosProduto();
        }
    }
}