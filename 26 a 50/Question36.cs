namespace ProjetoQuestoesCSharp._26_a_50

{
    internal class Question36
    {
        // Função para gerar os primeiros n números da sequência de Fibonacci
        public static void GerarSequenciaFibonacci(int n)
        {
            int num1 = 0, num2 = 1, num3, i;
            Console.Write($"{num1}, {num2}");

            for (i = 2; i < n; ++i)
            {
                num3 = num1 + num2;
                Console.Write($", {num3}");
                num1 = num2;
                num2 = num3;
            }
            Console.WriteLine();
        }

        // Função principal para chamar a função de Fibonacci
        public static void Executar()
        {
            // Gera e exibe exatamente os 10 primeiros números da sequência de Fibonacci
            int n = 10;
            GerarSequenciaFibonacci(n);
        }
    }
}