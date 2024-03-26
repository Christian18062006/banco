using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Conta
    {
        public string Titular
        {
            get;
            set
      ;
        }
        public double Saldo
        {
            get;
            private set;
        }
        public int NumeroConta
        {
            get;
            private set;
        }
        public Conta(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
        }
        public Conta(string titular, int numeroConta, double saldo) : this(titular, numeroConta)
        {
            Saldo = saldo;
        }
        public void setSaque()
        {
            double valor;
            Console.WriteLine("Digite o valor que você deseja sacar, levando em conta que será descontado do seu saldo $5,00.");
            valor = double.Parse(Console.ReadLine());
            Saldo -= valor;
            Saldo -= 5;
            if (Saldo <= 0)
            {
                Console.WriteLine("Saque realisado, mais agora o seu saldo está negativo.");
            }
            else
            {
                Console.WriteLine("Saque realizado com saldo positivo.");
            }
        }
        public void setDeposito()
        {
            double valor;
            Console.WriteLine("Digite o valor que deseja depositar.");
            valor = double.Parse(Console.ReadLine());
            Saldo += valor;
            Console.WriteLine($"Você fez um depósito de: {valor.ToString("C2")}");
        }
    }
}