using System;
using System.Collections.Generic;
using System.Text;

namespace banco
{
    class Conta
    {
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        public string Titular
        {
            get;
            set;
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
public void setDeposito(double valor)
        {
            Saldo+=valor;
        }
        public void setSaque(double valor)
        {
            Saldo-=valor+5;
        }
public override string ToString()
        {
            return ($"Titular: {Titular} \n número da conta: {NumeroConta} \n saldo atual: {Saldo.ToString("C2")}");
        }

    }
}