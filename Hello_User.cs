using System;
using System.Text;

class Do_Zero
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Digite seu nome: ");
        string nome_user = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        string idadeInput = Console.ReadLine();

        int idade_user = int.Parse(idadeInput);

        Console.WriteLine("Olá Usuario " + nome_user + " de " + idade_user + " anos.");
    }
}
