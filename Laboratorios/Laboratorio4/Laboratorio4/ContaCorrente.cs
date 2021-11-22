using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class ContaCorrente
    {

        private decimal saldo;
        private string nome;
        public int contador=0;
        public decimal acumulador;
        public decimal saldomedio;

  

        public void Depositar(decimal val)
        {
            saldo = saldo + val;
            contador = contador + 1;
            acumulador =  acumulador + val;

        }
        public void Sacar(decimal val)
        {
            saldo = saldo - val;
            contador = contador + 1;
            acumulador = acumulador + val;
        }

        public decimal Saldo
        {
            get { return saldo; }
        }

        public ContaCorrente(decimal val)
        {
            saldo = val;
            
        }


        public void SaldoMedio()

        {
          
            saldomedio = acumulador / contador;
        }

        public decimal SaldoMedioo
        {
            get { return saldomedio; }
        }
    

        public string Nome
        {

            get { return nome; }
            set { nome = value; }
   
        }

        public string Dataehora()
        {
            DateTime dt = new DateTime();
            string datadodia = dt.ToString();
            return (datadodia);
        }

      
  
 


    }
}
