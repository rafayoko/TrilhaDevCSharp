using System;
using System.Collections.Generic;
using System.Text;



namespace Laboratorio10
{
    public class TermometroLimite : Termometro
    {
        private double limiteSuperior;
        private bool disparadoEventoLimiteSuperior;
        public TermometroLimite(double ls)
        {
            limiteSuperior = ls;
            disparadoEventoLimiteSuperior = false;
        }
        public double LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }


        public delegate void MeuDelegate(string msg, double temp);

        public event MeuDelegate LimiteSuperiorEvent;
       
        private void OnLimiteSuperiorEvent()
        {
            // verifica se a temperatura ultrapassou o limite e
            // Verifica se o evento já foi disparado, para não disparar continuamente. 
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
                // verifica se há tratador
                if (LimiteSuperiorEvent != null)
                {
                    LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!", this.Temperatura);
                    disparadoEventoLimiteSuperior = true;
                }
        }
        //1. Altere a classe TermometroLimite para gerar um evento notificando que a temperatura voltou ao normal. 
        // Chame um método para diminuir a temperatura e utilize um tratador de evento adequado
        public event MeuDelegate TemperaturaVoltouAoNormal;

        public void OnTemperaturaVoltouAoNormalEvent()
        {
            if(Temperatura < this.limiteSuperior && this.disparadoEventoLimiteSuperior == true)
            {
               if(TemperaturaVoltouAoNormal != null)
                {
                    TemperaturaVoltouAoNormal("Temperatura voltou ao normal", this.Temperatura);
                    this.disparadoEventoLimiteSuperior = false;
                }
            }
        }
        public override void Aumentar()
        {
            base.Aumentar();
            OnLimiteSuperiorEvent();
        }
        public override void Aumentar(double quantia)
        {
            base.Aumentar(quantia);
            OnLimiteSuperiorEvent();
            
        }
        public override void Diminuir()
        {
            base.Diminuir();
            OnTemperaturaVoltouAoNormalEvent();
           if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            } 
        }
        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            OnTemperaturaVoltouAoNormalEvent();

           if ((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            } 
        }
    }


}
