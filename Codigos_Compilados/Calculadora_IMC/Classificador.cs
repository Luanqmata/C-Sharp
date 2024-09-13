using System;

namespace Aula_2___jack_chan_nosso_Idolo
{
    public class Classificador
    {
        public static string ClassificarIMC(double imc)
        {
            if (imc < 18.5)
            {
                return "Magro";
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                return "Peso normal";
            }
            else if (imc >= 25 && imc < 29.9)
            {
                return "Acima do peso";
            }
            else if (imc >= 30 && imc < 34.9)
            {
                return "Gordo (Obesidade grau 1)";
            }
            else if (imc >= 35 && imc < 39.9)
            {
                return "Muito gordo (Obesidade grau 2)";
            }
            else
            {
                return "Extremamente gordo (Obesidade grau 3)";
            }
        }
    }
}
