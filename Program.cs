using ProjetoQuestoesCSharp._1_a_25;
using ProjetoQuestoesCSharp._26_a_50;
using System;

while (true)
{
    Console.WriteLine("Selecione a questão que deseja testar, caso contrário digite (0) para sair: ");
    int questaoEscolhida = int.Parse(Console.ReadLine());
    // O método static foi utilizado para que não precisasse instanciar cada questao para executá-la

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
        case 8:
            Question8.Tabuada();
            break;
        case 9:
            Question9.SomaNumeros1aN();
            break;
        case 10:
            Question10.CelsiusParaFahrenheit();
            break;
        case 11:
            Question11.StringVaziaOrNula();
            break;
        case 12:
            Question12.Pares_1a50();
            break;
        case 13:
            Question13.MaiorDos3();
            break;
        case 14:
            Question14.InverteString();
            break;
        case 15:
            Question15.Votar();
            break;
        case 16:
            Question16.PositivoOrNegativo();
            break;
        case 17:
            Question17.MediaNotas();
            break;
        case 18:
            Question18.BuscaLetraA();
            break;
        case 19:
            Question19.NumerosDecrescente1_10();
            break;
        case 20:
            Question20.SomaQuadradoDosNumeros1aN();
            break;
        case 21:
            Question21.BoasVindas();
            break;
        case 22:
            Question22.DobroETriplo();
            break;
        case 23:
            Question23.UltimoCaracterString();
            break;
        case 24:
            Question24.HorasEmSegundps();
            break;
        case 25:
            Question25.DivisivelPor3e5();
            break;
        case 26:
            Question26.Ordena3Numeros();
            break;
        case 27:
            Question27.Fatorial();
            break;
        case 28:
            Question28.Executar();
            break;
        case 29:
            Question29.MediaListaNumeros();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opção Inválida! Tente Novamente..");
            break;
    }
}
