using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuestoesCSharp._51_a_75
{
    internal class Question51
    {
        // Crie uma função que verifica se uma matriz é simétrica. 
        public static void VerificaMatrizSimetrica()
        {
            Console.WriteLine("---- Questão 51. Crie uma função que verifica se uma matriz é simétrica.! ----");
            Console.Write("Digite o tamanho da matriz (número de linhas e colunas,Ex: para uma matriz 3x3 digite 3): ");
            int tamanhoMatriz = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tamanhoMatriz, tamanhoMatriz];

            for (int i = 0; i < tamanhoMatriz; i++)
            {
                for (int j = 0; j < tamanhoMatriz; j++)
                {
                    Console.Write($"Digite o valor da matriz na posição ({i},{j}): ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            bool matrizIsSimetrica = true;   // inicializando dizendo que a matriz é simétrica para fazer as comparações
            for (int i = 0;i < tamanhoMatriz;i++)
            {
                for (int j = 0;j < tamanhoMatriz;j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                    {
                        matrizIsSimetrica = false;
                        break;
                    }
                }
                if (!matrizIsSimetrica)
                {
                    break;
                }
            }

            if (matrizIsSimetrica)
            {
                Console.WriteLine("A matriz digitada para a verificação é simétrica!");
            }
            else
            {
                Console.WriteLine("A matriz digitada para a verificação não é simétrica!");
            }
        }
    }
}
