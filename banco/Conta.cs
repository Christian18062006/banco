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
        public Conta(string titular, int numeroConta, double saldo): this(titular, numeroConta)
        {
            Saldo = saldo;
        }
    }
}