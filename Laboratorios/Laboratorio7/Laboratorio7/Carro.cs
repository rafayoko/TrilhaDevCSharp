using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio7
{
    public class Carro
    {

        private double velocidade;
     
        public double Velocidade
        {
            get
            {
                return velocidade;
            }
            
        }
        public void Acelarar(double v)
        {
           velocidade += v;
        }
        public void Diminuir(double v)
        {
            velocidade -= v;

        }


    }
}
