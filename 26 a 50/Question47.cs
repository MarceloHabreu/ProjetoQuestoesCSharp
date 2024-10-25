using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._26_a_50
{
    internal class Question47
    {
        // Crie uma função que soma duas matrizes 2x2.
        public static void SomaMatrizes2x2()
        {
            Console.WriteLine("Digite os valores de cada matriz para que possa fazer sua respectiva soma!");
            int[,] matrizA = new int[2, 2];
            int[,] matrizB = new int[2, 2];

            for (int i = 0; i < 2; i++) // Percorre as linhas
            {
                for (int j = 0; j < 2; j++) // Percorre as colunas
                {
                    Console.Write($"Digite o valor da matriz A na posição ({i},{j}): ");   // utilizando de aninhamento de for para que possa percorrer a matriz e adicionar os valores no lugar correto
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++) // Percorre as linhas
            {
                for (int j = 0; j < 2; j++) // Percorre as colunas
                {
                    Console.Write($"Digite o valor da matriz B na posição ({i},{j}): ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                };
            }

            int[,] sum = new int[2, 2];
            for (int i = 0;i < 2; i++)   // Percorre as linhas
            {
                for (int j = 0; j < 2; j++) // Percorre as colunas
                {
                    sum[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            Console.WriteLine("A soma das duas matrizes é:");
            for (int i = 0; i < 2; i++)     // Percorre as linhas
            {
                for (int j = 0; j < 2; j++)    // Percorre as colunas
                {
                    Console.Write(sum[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
