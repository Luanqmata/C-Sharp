using System;
using System.Collections.Generic;
using System.Linq;

public class Livro
{
    private string Titulo { get; set; }
    private string Descricao { get; set; }

    public Livro(string titulo, string descricao)
    {
        Titulo = titulo;
        Descricao = descricao;
    }

    public int ContarPalavras()
    {
        string[] palavras = Descricao.Split();
        return palavras.Length;
    }

    public static string ExtrairIniciais(string nomeAutor)
    {
        string[] nomes = nomeAutor.Split();
        string iniciais = "";

        foreach (string nome in nomes)
        {
            iniciais += nome[0].ToString().ToUpper();
        }
        return iniciais;
    }

    public static List<string> BuscarLivrosPorPalavraChave(List<Livro> livros, string palavraChave)
    {
        List<string> livrosEncontrados = new List<string>();

        foreach (var livro in livros)
        {
            if (livro.Descricao.ToLower().Contains(palavraChave.ToLower()))
            {
                livrosEncontrados.Add(livro.Titulo);
            }
        }
        return livrosEncontrados;
    }

    public static List<Livro> OrdenarLivrosPorTitulo(List<Livro> livros)
    {
        return livros.OrderBy(livro => livro.Titulo).ToList();
    }

    public static int ContarOcorrenciasDeLetra(List<Livro> livros, char letra)
    {
        int contador = 0;
        letra = char.ToLower(letra);

        foreach (var livro in livros)
        {
            foreach (var caractere in livro.Descricao.ToLower())
            {
                if (caractere == letra)
                {
                    contador++;
                }
            }
        }
        return contador;
    }

    public static string ConcatenarDescricoes(List<Livro> livros)
    {
        string concatenacao = "";

        foreach (var livro in livros)
        {
            concatenacao += livro.Descricao + " ";
        }
        return concatenacao.Trim();
    }

    public string TituloLivro => Titulo;
    public string DescricaoLivro => Descricao;
}

public class Program
{
    public static void Main()
    {
        List<Livro> biblioteca = new List<Livro>
        {
            new Livro("C# para Iniciantes", "Este livro aborda os conceitos básicos de programação em C# e como usá-los para criar aplicativos simples."),
            new Livro("Desenvolvimento Web com JavaScript", "Aqui você aprenderá a trabalhar com JavaScript, HTML e CSS para criar páginas e aplicações web interativas."),
            new Livro("Introdução ao Python", "Este livro oferece uma introdução ao Python, cobrindo tópicos como variáveis, loops, funções e bibliotecas populares.")
        };

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n===== Biblioteca =====");
            Console.WriteLine("1 - Adicionar Livro");
            Console.WriteLine("2 - Contar Palavras de um Livro");
            Console.WriteLine("3 - Buscar Livros por Palavra-Chave");
            Console.WriteLine("4 - Ordenar Livros por Título");
            Console.WriteLine("5 - Contar Ocorrências de uma Letra");
            Console.WriteLine("6 - Concatenar Descrições dos Livros");
            Console.WriteLine("7 - Sair");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite o título do livro: ");
                    string titulo = Console.ReadLine();
                    Console.Write("Digite a descrição do livro: ");
                    string descricao = Console.ReadLine();
                    Livro novoLivro = new Livro(titulo, descricao);
                    biblioteca.Add(novoLivro);
                    Console.WriteLine("Livro adicionado com sucesso!");
                    break;

                case "2":
                    if (biblioteca.Count > 0)
                    {
                        Console.Write("Digite o índice do livro para contar as palavras: ");
                        int indice = int.Parse(Console.ReadLine());
                        if (indice >= 0 && indice < biblioteca.Count)
                        {
                            Console.WriteLine($"Contagem de palavras do livro '{biblioteca[indice].TituloLivro}': {biblioteca[indice].ContarPalavras()}");
                        }
                        else
                        {
                            Console.WriteLine("Índice inválido!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nenhum livro cadastrado!");
                    }
                    break;

                case "3":
                    Console.Write("Digite a palavra-chave para buscar: ");
                    string palavraChave = Console.ReadLine();
                    List<string> livrosEncontrados = Livro.BuscarLivrosPorPalavraChave(biblioteca, palavraChave);
                    if (livrosEncontrados.Count > 0)
                    {
                        Console.WriteLine("Livros encontrados com a palavra-chave: ");
                        Console.WriteLine(string.Join(", ", livrosEncontrados));
                    }
                    else
                    {
                        Console.WriteLine("Nenhum livro encontrado!");
                    }
                    break;

                case "4":
                    List<Livro> livrosOrdenados = Livro.OrdenarLivrosPorTitulo(biblioteca);
                    Console.WriteLine("Livros ordenados por título:");
                    foreach (var livro in livrosOrdenados)
                    {
                        Console.WriteLine(livro.TituloLivro);
                    }
                    break;

                case "5":
                    Console.Write("Digite a letra para contar as ocorrências: ");
                    char letra = char.Parse(Console.ReadLine());
                    int ocorrencias = Livro.ContarOcorrenciasDeLetra(biblioteca, letra);
                    Console.WriteLine($"A letra '{letra}' aparece {ocorrencias} vezes nas descrições dos livros.");
                    break;

                case "6":
                    string concatenacao = Livro.ConcatenarDescricoes(biblioteca);
                    Console.WriteLine("Descrições concatenadas: ");
                    Console.WriteLine(concatenacao);
                    break;

                case "7":
                    continuar = false;
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
