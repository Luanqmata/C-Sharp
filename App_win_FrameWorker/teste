using System;
using System.Text;

class Do_Zero
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        string prefixo = "000000000000000000000000000000000000000000000000000000000000";
        string caracteres = "0123456789abcdef";

        for (int i = 0; i < 65000; i++)
        {
            gerador_chaves(prefixo, caracteres);
        }

    }
    static void gerador_chaves(string prefixo, string caracteres)
    {   //1° chamar metodos de manipulç~~ao 
        Random random = new Random(); //1° aleatoriza escolhas
        StringBuilder chaveBuilder = new StringBuilder(); // 2° armazena a chave

        for (int i = 0; i < 4; i++)
        {
            int pos_Aleatoria = random.Next(caracteres.Length);//escolhe uma posição de acordo com a soma do carcters
            char caractereAleatorio = caracteres[pos_Aleatoria]; //pega o carcter aleatorio de acordo com a pos 

            chaveBuilder.Append(caractereAleatorio);//manda a chave gerada 
        }
        string chaveGerada = prefixo + chaveBuilder.ToString();
        Console.WriteLine(chaveGerada);
    }
}
