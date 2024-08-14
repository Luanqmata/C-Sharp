using System;

class Do_Zero
{
    static void Main()
    {
        Console.WriteLine("Digite um numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine("O numero é par");
        }
        else
        {
            Console.WriteLine("o numero é impar");
        }
    }
}
