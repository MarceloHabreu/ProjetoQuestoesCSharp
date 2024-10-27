using ProjetoQuestoesCSharp._1_a_25;
using ProjetoQuestoesCSharp._26_a_50;
using ProjetoQuestoesCSharp._51_a_75;
using System;
using System.Runtime.Intrinsics.X86;

while (true)
{
    Console.WriteLine("===== Menu de Questões =====");
    Console.WriteLine("Digite o número da questão para executá-la ou (0) para sair:");



    int questaoEscolhida = int.Parse(Console.ReadLine());
    Console.Clear();
    // O método static foi utilizado para que não precisasse instanciar cada questao para executá-la

    switch (questaoEscolhida)
    {
        case 1:
            // 1. Crie uma classe Produto com propriedades Nome e Preco.
            Question1.Executar(); 
            break;
        case 2:
            // 2. Instancie um objeto da classe Produto e exiba seus valores.
            Question2.Executar();
            break;
        case 3:
            // 3. Crie um método que soma dois números inteiros e exibe o resultado.
            Question3.Soma();
            break;
        case 4:
            // 4. Escreva uma função que verifica se um número é par ou ímpar.
            Question4.ParOrImpar();
            break;
        case 5:
            // 5. Implemente um método que converte um valor em metros para centímetros.
            Question5.ConversorCentimetros();
            break;
        case 6:
            // 6. Crie um programa que recebe a idade e verifica se a pessoa é maior de idade.
            Question6.VerificadorIdade();
            break;
        case 7:
            // 7. Escreva um método que calcula a área de um círculo com base no raio fornecido.
            Question7.CalculaAreaCirculo();
            break;
        case 8:
            // 8. Crie um programa que exibe a tabuada de um número fornecido.
            Question8.Tabuada();
            break;
        case 9:
            // 9. Desenvolva um método que soma todos os números de 1 a N.
            Question9.SomaNumeros1aN();
            break;
        case 10:
            // 10. Implemente uma função que converte temperatura de Celsius para Fahrenheit.
            Question10.CelsiusParaFahrenheit();
            break;
        case 11:
            // 11. Crie uma função que verifica se uma string é vazia ou nula.
            Question11.StringVaziaOrNula();
            break;
        case 12:
            // 12. Crie uma função que exibe todos os números pares entre 1 e 50.
            Question12.Pares_1a50();
            break;
        case 13:
            // 13. Implemente uma função que recebe três números e retorna o maior deles.
            Question13.MaiorDos3();
            break;
        case 14:
            // 14. Crie um programa que inverte uma string.
            Question14.InverteString();
            break;
        case 15:
            // 15. Desenvolva uma função que verifica se uma pessoa pode votar, dado o ano de nascimento.
            Question15.Votar();
            break;
        case 16:
            // 16. Crie uma função que verifica se um número é positivo ou negativo.
            Question16.PositivoOrNegativo();
            break;
        case 17:
            // 17. Implemente um programa que calcula a média de três notas e exibe a situação (Aprovado / Reprovado).
            Question17.MediaNotas();
            break;
        case 18:
            // 18. Escreva uma função que conta quantas letras &#39;a&#39; existem em uma string.
            Question18.BuscaLetraA();
            break;
        case 19:
            // 19. Crie um programa que imprime números de 1 a 10 em ordem decrescente.
            Question19.NumerosDecrescente1_10();
            break;
        case 20:
            // 20. Implemente uma função que calcula a soma dos quadrados dos números de 1 a N.
            Question20.SomaQuadradoDosNumeros1aN();
            break;
        case 21:
            // 21. Crie uma função que recebe o nome e a idade de uma pessoa e exibe uma mensagem de boas - vindas.
            Question21.BoasVindas();
            break;
        case 22:
            // 22. Escreva um programa que recebe um número e exibe seu dobro e triplo.
            Question22.DobroETriplo();
            break;
        case 23:
            // 23. Crie uma função que retorna o último caractere de uma string fornecida.
            Question23.UltimoCaracterString();
            break;
        case 24:
            // 24. Implemente uma função que converte horas em segundos.
            Question24.HorasEmSegundps();
            break;
        case 25:
            // 25. Crie uma função que verifica se um número é divisível por 3 e por 5.
            Question25.DivisivelPor3e5();
            break;
        case 26:
            // 26. Crie uma função que ordena três números fornecidos.
            Question26.Ordena3Numeros();
            break;
        case 27:
            // 27. Desenvolva um programa que calcula o fatorial de um número.
            Question27.Fatorial();
            break;
        case 28:
            // 28. Crie uma classe Aluno com propriedades Nome e Nota. Implemente um método para exibir esses valores. 
            Question28.Executar();
            break;
        case 29:
            // 29. Implemente um método que calcula a média de uma lista de números.
            Question29.MediaListaNumeros();
            break;
        case 30:
            // 30. Crie um programa que verifica se uma palavra é um palíndromo.
            Question30.DescubraPalidromo();
            break;
        case 31:
            // 31. Implemente uma função que encontra o menor número em um array.
            Question31.MenorNumeroArray();
            break;
        case 32:
            // 32. Crie uma função que multiplica todos os elementos de um array por um valor fornecido.
            Question32.MultiplicaValoresArray();
            break;
        case 33:
            // 33. Desenvolva uma função que retorna a soma dos números ímpares em um array.
            Question33.NumerosImparesEmArray();
            break;
        case 34:
            // 34. Crie uma classe Carro com propriedades Marca e Ano.
            Question34.Executar(); 
            break;
        case 35:
            // 35. Implemente um método para verificar se um ano é bissexto.
            Question35.DescobreAnoBissexto(); 
            break;
        case 36:
            // 36. Crie uma função que exibe os 10 primeiros números da sequência de Fibonacci.
            Question36.Executar(); 
            break;
        case 37:
            // 37. Desenvolva um programa que recebe uma string e substitui todos os espaços por '_'
            Question37.SubstituiString(); 
            break;
        case 38:
            // 38. Crie uma função que retorna o índice do maior elemento de um array.
            Question38.IndiceMaiorElemArray(); 
            break;
        case 39:
            // 39. Implemente uma função que calcula o MDC (Máximo Divisor Comum) entre dois números.
            Question39.CalcularMDC(); 
            break;
        case 40:
            // 40. Desenvolva uma função que retorna o número de vogais em uma string.
            Question40.ContarVogais();  
            break;
        case 41:
            // 41. Crie uma função que converte um número decimal para binário.
            Question41.DecimalParaBinario(); 
            break;
        case 42:
            // 42. Implemente uma função que recebe um número e exibe sua representação em palavras.
            Question42.NumeroParaPalavras(); 
            break;
        case 43:
            // 43. Crie um programa que simula o lançamento de um dado 100 vezes e exibe a frequência de cada valor.
            Question43.LancamentoDado(); 
            break;
        case 44:
            // 44. Desenvolva uma função que calcula o IMC e determina a categoria (baixo peso, normal, etc.).
            Question44.CalculaIMC(); 
            break;
        case 45:
            // 45. Crie uma função que encontra o segundo maior número em um array.
            Question45.SegundoMaiorNoArray(); 
            break;
        case 46:
            // 46. Implemente um programa que inverte os elementos de um array.
            Question46.InverteElementosArray();  
            break;
        case 47:
            // 47. Crie uma função que soma duas matrizes 2x2.
            Question47.SomaMatrizes2x2(); 
            break;
        case 48:
            // 48. Desenvolva uma função que recebe uma data e exibe o dia da semana correspondente.
            Question48.ExibeDiaSemana();
            break;
        case 49:
            // 49. Crie um programa que verifica se uma string contém apenas letras e números.
            Question49.VerificaString(); 
            break;
        case 50:
            // 50. Implemente uma função que calcula o valor de uma potência sem usar Math.Pow().
            Question50.CalculaPotencia(); 
            break;
        case 51:
            //51. Crie uma função que verifica se uma matriz é simétrica.
            Question51.VerificaMatrizSimetrica(); 
            break;
        case 52:
            // 52. Desenvolva um programa que ordena uma lista de nomes em ordem alfabética.
            Question52.OrdernaNomes(); 
            break;
        case 53:
            // 53. Crie uma função que encontra o elemento mais frequente em um array.
            Question53.BuscaFrequenciaArray(); 
            break;
        case 54:
            // 54. Implemente uma função que calcula o valor absoluto de um número sem usar Math.Abs().
            Question54.CalculaValorAbsoluto(); 
            break;
        case 55:
            // 55. Crie um programa que implementa o algoritmo de busca linear.
            Question55.AlgoritmoDeBuscaLinear();
            break;
        case 0:
            return;
        default:
            Console.WriteLine("Opção Inválida! Tente Novamente..");
            break;
    }
}
