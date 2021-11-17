using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio4
{
    class ContaCorrente
    {

        private decimal saldo;
        private int contador = 0;
        private decimal acumulador = 0;
        private decimal saldomedio;

        


        public void Depositar(decimal val)
        {
            saldo = saldo + val;
            contador = contador + 1;
            acumulador = acumulador + acumulador;

        }
        public void Sacar(decimal val)
        {
            saldo = saldo - val;
            contador = contador + 1;
            acumulador = acumulador + acumulador;
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



        private string nome;
      

        public string Nome
        {

            get { return nome; }
            set { nome = value; }
   
        }

  
 


    }
}
