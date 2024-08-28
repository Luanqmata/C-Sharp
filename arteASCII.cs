using System;

namespace HelloWorld
{
    class program
    {
        static void Main(string[] args)
        {

            string doguinho = @"
            __  
       (___()'`;
       /,    /` 
       \\'--\\
";
            string gato = @"
        |\---/|
        | o_o |
         \_^_/
";
            string coruja = @"
         /\_/\
        ((@v@))
        ():::()
         VV-VV
";

            Console.WriteLine("Digite um numero para Imprimir um desenho \n 1. Doguinho \n 2. gato \n 3. coruja ");
            int Input_user = Convert.ToInt32(Console.ReadLine());
            if (Input_user == 1)
            {
                Console.WriteLine(doguinho);
            }
            else if (Input_user == 2)
            {
                Console.WriteLine(gato);
            }
            else if (Input_user == 3) { 
                Console.WriteLine(coruja);
            }
        }
    }
}
