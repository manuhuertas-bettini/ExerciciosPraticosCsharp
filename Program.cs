using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTA DE EXERCÍCIOS PRÁTICOS - C# ===");
            Console.WriteLine("1 - Ex 1: Calculando uma compra");
            Console.WriteLine("2 - Ex 2: Classificação de notas");
            Console.WriteLine("3 - Ex 3: Adivinhe o número (com do-while)");
            Console.WriteLine("4 - Ex 4: Calculadora com métodos");
            Console.WriteLine("5 - Ex 5: Cadastro de notas em um array");
            Console.WriteLine("6 - Ex 6: Lista de produtos");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");

            if (int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Ex1();
                        break;
                    case 2:
                        Ex2();
                        break;
                    case 3:
                        Ex3();
                        break;
                    case 4:
                        Ex4();
                        break;
                    case 5:
                        Ex5();
                        break;
                    case 6:
                        Ex6();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do programa... Até mais!");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido.");
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }

        } while (opcao != 0);
    }


    // EX 1 — Calculando uma compra
    static void Ex1()
    {
        Console.WriteLine("--- EX 1: CALCULANDO UMA COMPRA ---");

        Console.Write("Digite o nome do produto: ");
        string produto = Console.ReadLine() ?? "";

        Console.Write("Digite a quantidade comprada: ");
        int quantidade = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o preço unitário (R$): ");
        decimal precoUnitario = decimal.Parse(Console.ReadLine() ?? "0");

        decimal valorTotal = quantidade * precoUnitario;

        Console.WriteLine("\n--- RESUMO DA COMPRA ---");
        Console.WriteLine($"Produto: {produto}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Preço Unitário: R$ {precoUnitario:F2}");
        Console.WriteLine($"Valor Total: R$ {valorTotal:F2}");
    }

    // EX 2 — Classificação de notas
    static void Ex2()
    {
        Console.WriteLine("--- EX 2: CLASSIFICAÇÃO DE NOTAS ---");

        Console.Write("Digite o nome do aluno: ");
        string aluno = Console.ReadLine() ?? "";

        Console.Write("Digite a nota (0 a 10): ");
        if (double.TryParse(Console.ReadLine(), out double nota))
        {
            if (nota >= 0 && nota <= 10)
            {
                string classificacao;

                if (nota >= 7)
                {
                    classificacao = "Aprovado";
                }
                else if (nota >= 5)
                {
                    classificacao = "Recuperação";
                }
                else
                {
                    classificacao = "Reprovado";
                }

                Console.WriteLine($"Aluno: {aluno}");
                Console.WriteLine($"Nota: {nota:F1}");
                Console.WriteLine($"Classificação: {classificacao}");
            }
            else
            {
                Console.WriteLine("\nErro: A nota deve estar entre 0 e 10!");
            }
        }
        else
        {
            Console.WriteLine("\nErro: Digite uma nota numérica válida!");
        }
    }

    // EX 3 — Adivinhe o número (Desafio do-while)
    static void Ex3()
    {
        Console.WriteLine("--- EX 3: ADIVINHE O NÚMERO ---");

        int numeroSecreto = 15;
        int tentativa;
        int totalTentativas = 0;

        do
        {
            Console.Write("Digite seu palpite: ");
            tentativa = int.Parse(Console.ReadLine() ?? "0");
            totalTentativas++;

            if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número secreto é MAIOR!");
            }
            else if (tentativa > numeroSecreto)
            {
                Console.WriteLine("O número secreto é MENOR!");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número secreto ({numeroSecreto})!");
                Console.WriteLine($"Quantidade total de tentativas: {totalTentativas}");
            }

        } while (tentativa != numeroSecreto);
    }

    // EX 4 — Calculadora com métodos
    static double Somar(double a, double b) => a + b;
    static double Multiplicar(double a, double b) => a * b;

    static void Ex4()
    {
        Console.WriteLine("--- EX 4: CALCULADORA COM MÉTODOS ---");

        Console.Write("Digite o primeiro número: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Digite o segundo número: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        double resultadoSoma = Somar(num1, num2);
        double resultadoMultiplicacao = Multiplicar(num1, num2);

        Console.WriteLine($"Soma de {num1} + {num2} = {resultadoSoma}");
        Console.WriteLine($"Multiplicação de {num1} * {num2} = {resultadoMultiplicacao}");
    }

    // EX 5 — Cadastro de notas em um array
    static void Ex5()
    {
        Console.WriteLine("--- EX 5: CADASTRO DE NOTAS EM ARRAY ---");

        double[] notas = new double[3];

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Digite a {i + 1}ª nota: ");
            notas[i] = double.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("--- NOTAS CADASTRADAS (laço for) ---");
        for (int i = 0; i < notas.Length; i++)
        {
            Console.WriteLine($"Nota {i + 1}: {notas[i]:F1}");
        }

        double soma = 0;
        foreach (var nota in notas)
        {
            soma += nota;
        }

        double media = soma / notas.Length;

        Console.WriteLine($"Média das notas: {media:F2}");
    }
    
    // EX 6 — Lista de produtos
    static void Ex6()
    {
        Console.WriteLine("--- EX 6: LISTA DE PRODUTOS ---");

        List<string> produtos = new List<string>();

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Digite o nome do {i}º produto: ");
            string nomeProduto = Console.ReadLine() ?? "";
            produtos.Add(nomeProduto);
        }

        Console.WriteLine("--- PRODUTOS CADASTRADOS ---");
        foreach (var item in produtos)
        {
            Console.WriteLine($"- {item}");
        }

        Console.Write("Digite um produto para buscar na lista: ");
        string produtoBusca = Console.ReadLine() ?? "";

        if (produtos.Contains(produtoBusca, StringComparer.OrdinalIgnoreCase))
        {
            Console.WriteLine($"O produto '{produtoBusca}' ESTÁ na lista!");
        }
        else
        {
            Console.WriteLine($"O produto '{produtoBusca}' NÃO foi encontrado na lista.");
        }

        Console.Write("Digite o nome do produto que deseja remover: ");
        string produtoRemover = Console.ReadLine() ?? "";

        if (produtos.Remove(produtoRemover))
        {
            Console.WriteLine($"Produto '{produtoRemover}' removido com sucesso!");
        }
        else
        {
            Console.WriteLine($"Não foi possível remover: '{produtoRemover}' não encontrado.");
        }

        Console.WriteLine("--- LISTA ATUALIZADA DE PRODUTOS ---");
        foreach (var item in produtos)
        {
            Console.WriteLine($"- {item}");
        }
    }
}