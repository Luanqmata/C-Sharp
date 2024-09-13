using System;

namespace Aula_2___jack_chan_nosso_Idolo
{
    internal class ClassificaIMC
    {
        static void Main(string[] args)
        {
            CalculadoraIMC calculadora = new CalculadoraIMC();

            Console.WriteLine("Bem vindo ao classificador de IMC \n\n");

            Console.Write("Digite o seu peso: ");
            int peso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite sua Altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = calculadora.CalcularIMC(peso, altura);
            Console.WriteLine("Seu IMC é: " + imc.ToString("F2"));

            string classificacao = Classificador.ClassificarIMC(imc);
            Console.WriteLine("Você está: " + classificacao);
        }
    }
}
