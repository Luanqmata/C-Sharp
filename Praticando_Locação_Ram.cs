using System;


class Do_Zero
    {

    
    static void Main()
        {
        
            /*  ex2 
            Solicite ao usuário para inserir o nome do funcionário (string).
            Solicite ao usuário para inserir as horas trabalhadas na semana (int).
            Solicite ao usuário para inserir a taxa de pagamento por hora (double).
            Solicite ao usuário para inserir o valor das comissões recebidas na semana (decimal).
            Calcule o salário bruto (horas trabalhadas multiplicadas pela taxa de pagamento) e adicione as comissões.
            Exiba o nome do funcionário e o salário total (decimal) no final.
             */
            Console.Write("Digite o nome do Funcionario: ");
            string nome_funcionario = Console.ReadLine();
    
            Console.Write("Digite as Horas Trabalhadas do funcionario " + nome_funcionario + " : ");
            int horas_trabalhadas = Convert.ToInt32(Console.ReadLine());
    
            Console.Write("Digite a taxa de pagamento por hora do seu trabalho: " );
            decimal taxa_pagamento = Convert.ToDecimal(Console.ReadLine());
    
            Console.Write("Digite o Valor das suas Comissoes recebidas: ");
            decimal comissao_recebidas = Convert.ToDecimal(Console.ReadLine());
    
            decimal salario_bruto =(horas_trabalhadas * taxa_pagamento) + comissao_recebidas;
    
            Console.WriteLine($"O salário bruto do funcionário {nome_funcionario} é: {salario_bruto}");
    }
}
