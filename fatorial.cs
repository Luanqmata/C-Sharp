using System;

public class Program
{
    public static void Main(string[] args)
    {
        bool quebra_loop = false;

        while (!quebra_loop)
        {
            Console.Write("Digite o número para obter o fatorial dele (digite 0 para sair): ");
            int numero = ReadInt();

            if (numero == 0)
            {
                quebra_loop = true;
            }else if (numero == 5)
            {
                long fatorial = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
                Console.WriteLine("\nO nome do nosso professor é ROMES.");
            }
            else if (numero == 4)
            {
                long fatorial = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
                Console.WriteLine("\nO nome do criador é LUAN");
            }
            else if (numero >= 0)
            {
                long fatorial = CalcularFatorial(numero);
                Console.WriteLine($"O fatorial de {numero} é: {fatorial}");
            }
            else
            {
                Console.WriteLine("Digite um número positivo.");
            }
        }

        Console.WriteLine("Você saiu do programa.");
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

    public static long CalcularFatorial(int numero)
    {
        long fatorial = 1;
        for (int i = 2; i <= numero; i++)
        {
            fatorial *= i;
        }
        return fatorial;
    }
}
