using ProjetoQuestoesCSharp._1_a_100;
using ProjetoQuestoesCSharp._1_a_25;
using System;

while (true)
{
    Console.WriteLine("Selecione a questão que deseja testar, caso contrário digite (0) para sair: ");
    int questaoEscolhida = int.Parse(Console.ReadLine());

    switch (questaoEscolhida)
    {
        case 1:
            Question1.Executar();
            break;
        case 2:
            Question2.Executar();
            break;
        case 3:
            Question3.Soma();
            break;
        case 4:
            Question4.ParOrImpar();
            break;
        case 5:
            Question5.ConversorCentimetros();
            break;
        case 6:
            Question6.VerificadorIdade();
            break;
        case 7:
            Question7.CalculaAreaCirculo();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opção Inválida! Tente Novamente..");
            break;
    }
}
