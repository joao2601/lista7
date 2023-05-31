using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            //  ****EXERCÍCIO 1***

//            //double precototal = 0.0;
//            //int qtd;
//            //double preco;
//            //int totalItems = 0;

//            //Console.WriteLine("**TABELA DE PREÇOS**");
//            //Console.WriteLine("------------//--------//---------//-------");
//            //Console.WriteLine("Peixe = R$2,00");
//            //Console.WriteLine("Carne = R$10,00");
//            //Console.WriteLine("Rfrigerante = R$4,00");
//            //Console.WriteLine("------------------------------------------");
//            //Console.WriteLine("Insira a quantidade : ");
//            //qtd = int.Parse(Console.ReadLine());

//            //while ( qtd != 0)
//            //{

//            //    if(qtd <= 0)
//            //    {
//            //        break;
//            //    }
//            //    Console.WriteLine("--------------------------------------------------");
//            //    Console.WriteLine("Insira o valor do(s) produtos: ");
//            //    preco=double.Parse(Console.ReadLine());

//            //    precototal += (qtd * preco);

//            //    totalItems += qtd;

//            //    Console.WriteLine("A quantidade de produtos é: "+ totalItems  );
//            //    Console.WriteLine("O valor dos produtos é: " + precototal);
//            //}
//            //Console.ReadKey();


//            // ****EXERCÍCIO 2****

//            //string nomeProduto, nomeMaior, nomeMenor;
//            //int numItens;
//            //float preco, maiorValor, menorValor;
//            //int maiorqtd, menorqtd;
//            //int parada = 0;

//            //maiorValor = float.MaxValue;
//            //menorValor = float.MinValue;

//            //while (parada != 1)
//            //{
//            //    Console.WriteLine("Informe o nome do produto: ");
//            //    nomeProduto = Console.ReadLine();

//            //    Console.WriteLine("Insira a quantidade: ");
//            //    numItens = int.Parse(Console.ReadLine());

//            //    Console.WriteLine("Entre com o preço unitario: ");
//            //    preco= float.Parse(Console.ReadLine());

//            //    float total = numItens + preco;

//            //    if( total > maiorValor)
//            //    {
//            //        maiorValor = total;
//            //        nomeMaior = nomeProduto;
//            //    }
//            //    if(total< menorValor)
//            //    {
//            //        maiorValor = total;
//            //        nomeMenor = nomeProduto;
//            //    }
//            //    Console.WriteLine("Digite 1 para sair ou 2 para continuar");

//            //    parada = int.Parse(Console.ReadLine());
//            //}
//            //Console.WriteLine("Maior qtd investida {0} no produto {1}: ", maiorValor);
//            //Console.WriteLine("Menor qtd investida {0} no produto {1}: ", menorValor);

//            //Console.ReadKey()




//            //   ****EXERCÍCIO 3***

//            Console.WriteLine("****Cadastro de Pesos das Avaliações****");

//            Console.WriteLine("Digite o número de avaliações planejadas para o bimestre:");
//            int numeroAvaliacoes = int.Parse(Console.ReadLine());

//            double somaPesos = 0;
//            int contadorAvaliacoes = 1;

//            while (contadorAvaliacoes <= numeroAvaliacoes)
//            {
//                Console.WriteLine($"Digite o peso da avaliação {contadorAvaliacoes}:");
//                double peso = double.Parse(Console.ReadLine());

//                somaPesos += peso;
//                contadorAvaliacoes++;
//            }

//            Console.WriteLine("-------------------------------------")
//        if (somaPesos < 100)
//            {
//                Console.WriteLine($"A soma total dos pesos é insuficiente. Total: {somaPesos}%");
//            }
//            else if (somaPesos > 100)
//            {
//                Console.WriteLine($"A soma total dos pesos é excedente. Total: {somaPesos}%");
//            }
//            else
//            {
//                Console.WriteLine($"A soma total dos pesos é adequada. Total: {somaPesos}%");
//            }
//        }
//    }

//    // ****EXERCICIO 4

//    Console.Write("Informe a sigla do estado: ");
//        string sigla = Console.ReadLine();

//    string nomeEstado;
//        switch (sigla) {
//            case "AC":
//                nomeEstado = "Acre";
//                break;
//            case "AL":
//                nomeEstado = "Alagoas";
//                break;
//            case "AP":
//                nomeEstado = "Amapá";
//                break;
//            case "AM":
//                nomeEstado = "Amazonas";
//                break;
//            case "BA":
//                nomeEstado = "Bahia";
//                break;
//            case "CE":
//                nomeEstado = "Ceará";
//                break;
//            case "DF":
//                nomeEstado = "Distrito Federal";
//                break;
//            case "ES":
//                nomeEstado = "Espírito Santo";
//                break;
//            case "GO":
//                nomeEstado = "Goiás";
//                break;
//            case "MA":
//                nomeEstado = "Maranhão";
//                break;
//            case "MT":
//                nomeEstado = "Mato Grosso";
//                break;
//            case "MS":
//                nomeEstado = "Mato Grosso do Sul";
//                break;
//            case "MG":
//                nomeEstado = "Minas Gerais";
//                break;
//            case "PA":
//                nomeEstado = "Pará";
//                break;
//            case "PB":
//                nomeEstado = "Paraíba";
//                break;
//            case "PR":
//                nomeEstado = "Paraná";
//                break;
//            case "PE":
//                nomeEstado = "Pernambuco";
//                break;
//            case "PI":
//                nomeEstado = "Piauí";
//                break;
//            case "RJ":
//                nomeEstado = "Rio de Janeiro";
//                break;
//            case "RN":
//                nomeEstado = "Rio Grande do Norte";
//                break;
//            case "RS":
//                nomeEstado = "Rio Grande do Sul";
//                break;
//            case "RO":
//                nomeEstado = "Rondônia";
//                break;
//            case "RR":
//                nomeEstado = "Roraima";
//                break;
//            case "SC":
//                nomeEstado = "Santa Catarina";
//                break;
//            case "SP":
//                nomeEstado = "São Paulo";
//                break;
//            case "SE":
//                nomeEstado = "Sergipe";
//                break;
//            case "TO":
//                nomeEstado = "Tocantins";
//                break;
//            default:
//                Console.WriteLine("Erro: sigla inválida.");
//                return;
//        }

//Console.WriteLine("Estado: " + nomeEstado);
//    }
//}

////**** EXERCICIO 5

// bool continuar = true;

//while (continuar)
//{
//    Console.WriteLine("=== Verificação da Estação do Ano ===");
//    Console.Write("Digite um número inteiro entre 1 e 12: ");
//    int mes = int.Parse(Console.ReadLine());

//    string estacao;

//    switch (mes)
//    {
//        case 12:
//        case 1:
//        case 2:
//            estacao = "Verão";
//            break;
//        case 3:
//        case 4:
//        case 5:
//            estacao = "Outono";
//            break;
//        case 6:
//        case 7:
//        case 8:
//            estacao = "Inverno";
//            break;
//        case 9:
//        case 10:
//        case 11:
//            estacao = "Primavera";
//            break;
//        default:
//            Console.WriteLine("Mês inválido.");
//            continue;
//    }

//    if ((mes == 3 || mes == 9) && estacao == "Primavera" || (mes == 6 || mes == 12) && estacao == "Inverno")
//    {
//        Console.WriteLine("Há duas estações possíveis para esse mês.");
//        Console.Write("Informe '1' para considerar a estação anterior ou '2' para considerar a estação posterior: ");
//        int escolha = int.Parse(Console.ReadLine());

//        if (escolha == 1)
//        {
//            if (mes == 3)
//            {
//                estacao = "Outono";
//            }
//            else if (mes == 6)
//            {
//                estacao = "Verão";
//            }
//        }
//        else if (escolha == 2)
//        {
//            if (mes == 3)
//            {
//                estacao = "Primavera";
//            }
//            else if (mes == 6)
//            {
//                estacao = "Inverno";
//            }
//        }
//        else
//        {
//            Console.WriteLine("Opção inválida. Estação definida como a padrão.");
//        }
//    }

//    Console.WriteLine($"A estação correspondente ao mês {mes} é: {estacao}");

//    Console.WriteLine("Deseja verificar outra estação? (s/n)");
//    string opcao = Console.ReadLine();

//    if (opcao != "s")
//    {
//        continuar = false;
//    }

//    Console.WriteLine();
//}
//    }
//}

//// ****EXERCICIO 6****

//bool continuar = true;

//while (continuar)
//{
//    Console.WriteLine("=== Cálculo do IMC ===");
//    Console.Write("Informe o peso (em kg): ");
//    double peso = double.Parse(Console.ReadLine());

//    Console.Write("Informe a altura (em metros): ");
//    double altura = double.Parse(Console.ReadLine());

//    double imc = peso / (altura * altura);

//    Console.WriteLine($"Seu IMC: {imc:F2}");

//    Console.WriteLine("=== Faixa de Peso ===");

//    if (imc < 18.5)
//    {
//        Console.WriteLine("Abaixo do peso");
//    }
//    else if (imc >= 18.5 && imc <= 24.9)
//    {
//        Console.WriteLine("Peso normal");
//    }
//    else if (imc >= 25.0 && imc <= 29.9)
//    {
//        Console.WriteLine("Sobrepeso");
//    }
//    else if (imc >= 30.0 && imc <= 34.9)
//    {
//        Console.WriteLine("Obesidade grau 1");
//    }
//    else if (imc >= 35.0 && imc <= 39.9)
//    {
//        Console.WriteLine("Obesidade grau 2");
//    }
//    else
//    {
//        Console.WriteLine("Obesidade grau 3 (mórbida)");
//    }

//    Console.WriteLine("Deseja calcular o IMC novamente? (s/n)");
//    string opcao = Console.ReadLine();

//    if (opcao != "s")
//    {
//        continuar = false;
//    }

//    Console.WriteLine();
//}
//    }
//}


//// ****EXERCICIO 7

//int n;

//Console.WriteLine("Digite um número inteiro positivo: "))

//i = 1
//("Divisores de", n, ":")

//while i <= n:
//    if n % i == 0:
//       (i)
//    i += 1
//        }
//    }
//}
