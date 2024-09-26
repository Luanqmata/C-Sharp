using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("\nDigite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("\nDigite a quantidade de maçãs que vc possue: ");
        int macas = ReadInt();

        Console.Write($"\nO usuario: {nome} , possui {macas} maçãs.\n");
    }

    public static int ReadInt()
    {
        int resultado;
        while (true)
        {
            string entrada = Console.ReadLine();
            if (int.TryParse(entrada, out resultado))
            {
                return resultado;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
        }
    }

}
