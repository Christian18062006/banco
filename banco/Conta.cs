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
        public void setSaque(double valor)
        {
            Saldo -= valor;
            Saldo -= 5;
        }
        public void setDeposito(double valor)
        {
            Saldo += valor;
        }
        public override string ToString()
        {
            return ($"Titular: {Titular} \n número da conta: {NumeroConta} \n saldo atual: {Saldo.ToString("C2")}");
        }

    }
}