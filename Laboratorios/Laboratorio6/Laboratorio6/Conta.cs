using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio6
{
    public abstract class Conta
    {
        private decimal saldo;
        private string titular;
       

        public Conta(string t, decimal s)
        {
            titular = t;
            saldo = s;
           
        }
     
        public decimal Saldo
        {
            get { return saldo; }
        }
        public string Titular
        {
            get { return titular; }
        }

        public abstract string Id
        {
            get;
        }
        public virtual void Depositar(decimal valor)
        {
            saldo += valor;
        }
        public virtual void Sacar(decimal valor)
        {
            saldo -= valor;
        }
    }
}
