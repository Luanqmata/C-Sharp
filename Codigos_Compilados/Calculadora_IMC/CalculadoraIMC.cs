using System;

namespace Aula_2___jack_chan_nosso_Idolo
{
    internal class CalculadoraIMC
    {
        public  double CalcularIMC(int peso , double altura)
        {
            return (double)peso / ( altura * altura) ;
        }
    }
}
