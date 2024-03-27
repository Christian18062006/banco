using System;

namespace banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string titlular;
            double valor;
            int numeroConta;
            int opcao;
            Console.WriteLine("Bem-vindo ao banco central.");
            Conta conta;
            Console.WriteLine("Digite o nome do titular.");
            titlular = Console.ReadLine();
            Console.WriteLine("Digite o número da conta, esse número não poderá ser alterado.");
            numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Deseja criar a conta com um saldo inicial? digite 1 para sim ou 2 para não.");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Digite o depósito inicial.");
                valor = double.Parse(Console.ReadLine());
                conta = new Conta(titlular, numeroConta, valor);
                Console.WriteLine($"Conta criada. informações da conta: {conta}");
            }
            else
            {
                conta = new Conta(titlular, numeroConta);
                Console.WriteLine($"Conta criada. dados da conta: {conta}");
            }
            while (opcao != 5)
            {
                Console.WriteLine("Digite 5 para fechar o menu do caixa eletrônico.");
                Console.WriteLine("Digite 1 para sacar. ou digite 2 para depositar.");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("Digite o valor do saque, um valor de $5 será debitado da sua conta.");
                            valor = double.Parse(Console.ReadLine());
                            if (conta.Saldo < 0)
                            {
                                conta.setSaque(valor);
                                Console.WriteLine("Saque realizado, mais agora você está com um saldo negativo. \n");
                                Console.WriteLine($"Dados da conta atualmente: {conta} \n");
                            }
                            else
                            {
                                conta.setSaque(valor);
                                Console.WriteLine("Saque realizado, e você continua com um saldo positivo.");
                                Console.WriteLine($"Dados da conta atualmente: {conta} \n")
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Digite o valor que deseja depositar.");
                            valor = double.Parse(Console.ReadLine());
                            conta.setDeposito(valor);
                            Console.WriteLine("Depósito realizado.");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("inválido, o menu será encerrado.");
                            break;
                        }
                }
            }
        }
    }
}
