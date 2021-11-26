using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio7
{
    class CarroEletrico : Carro, IEstadoBinario
    {
        private bool ligado;
        private decimal velocidade;
       
        public CarroEletrico(decimal v)
        {
            velocidade = v;
        }

        public void Ligar()
        {
            ligado = true;
        }

        public void Desligar()
        {
            ligado = false;
        }
        public EstadoBinario Estado
        {
            get
            {
                if (velocidade > 0)
                    return EstadoBinario.Ligado;
                else
                    return EstadoBinario.Desligado;
            }
        }
    }
}
