using System;


class Do_Zero
    {

    
    static void Main()
        {


            Console.Write("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro número: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            // media
            double media = (num1 + num2 + num3) / 3; // trabalhando com numero quebrado
            Console.WriteLine("A média é :" + media );
            /*
            // double 
                numeros quebrados

               //USAR FLOAT
            float pi = 3.1415f ;
            
                // USAR DECIMAL  (128 bits)
            decimal ValorSaldo = 100.25m;
            decimal GrandeValor = 1.23e10m = 1.23 *10 ^ 10;
            
                // USAR LONGO 
            long populaçãoMundial = 7800000000000L;
                
                // ARMAZENAR EM BYte
            byte idade = 33; 0 até 255;
            
                // armazernar em shot 
            short temperatura = 30; max 32,766 e min 32,766 // usado para numeros pequenos
            */
    }
}
