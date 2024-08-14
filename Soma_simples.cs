using System;

class Do_Zero
{
  static void Main()
    {
        Console.WriteLine("Digite um numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int soma = num1 + num2;

        Console.WriteLine("A soma dos numeros sao " + soma);
    }
}
