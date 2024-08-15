using System;

class Tabuada
{
    static void Main()
    {
        Console.WriteLine("Digite um numero para ver a tabuada: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            int conta = num1 * i;
            Console.WriteLine(num1 + " x " + i + " = " + conta);
        }
    }
}
