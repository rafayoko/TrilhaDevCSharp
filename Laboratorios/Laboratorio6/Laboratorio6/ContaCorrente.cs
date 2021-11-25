using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio6
{
    public class ContaCorrente : Conta
    {
   
        public ContaCorrente(string t, decimal s) : base(t, s)
        {
        }

        public override string Id
        {
            get { return this.Titular + "(CC)"; }
        }
    }
}
