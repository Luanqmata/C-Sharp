using System;
using System.IO;

namespace CalculadoraCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("Bem-vindo à Calculadora");

                    Console.Write("Digite o primeiro número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Escolha a operação: (+, -, /, *)");
                    string operador = Console.ReadLine().Trim(); // apagar espaços em branco 

                    double resultado = 0;

                    switch (operador)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;
                        case "-":
                            resultado = num1 - num2;
                            break;
                        case "*":
                            resultado = num1 * num2;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("Número dividido por 0 não é permitido.");
                            }
                            resultado = num1 / num2;
                            break;
                        default:
                            throw new InvalidOperationException("Escolha uma das operações válidas: (+, -, /, *).");
                    }
                    Console.WriteLine($"O resultado da operação é: {resultado}");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Formato de entrada inválido. Por favor, insira números em PT-BR.");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("\nDeseja realizar outra operação? ([s/n])");
                string resposta = Console.ReadLine().Trim().ToLower();

                if (resposta != "s")
                {
                    continuar = false;
                    Console.WriteLine("\nSaindo do programa...");
                }
            }
        }
    }
}
