using System;

namespace Laboratorio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // inicializa o termometro e mostra seu valor
            TermometroLimite term = new TermometroLimite(5);
            Console.WriteLine(term.ToString());
            // adiciona um tratador ao evento LimiteSuperiorEvent
            term.LimiteSuperiorEvent += new TermometroLimite.MeuDelegate(TrataLimiteSuperior);
            term.TemperaturaVoltouAoNormal += new TermometroLimite.MeuDelegate(TrataTemperaturaVoltouAoNormal);
            // aumentar a temperatura além do limite term.Aumentar(6); 
            term.Aumentar(5);
           
            Console.WriteLine(term.ToString());
            term.Diminuir(5);
            Console.WriteLine(term.ToString());
        }
        private static void TrataLimiteSuperior(string msg, double temp)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Temperatura atual: " + temp);
        }

        private static void TrataTemperaturaVoltouAoNormal(string msg, double temp)
        {
            Console.WriteLine(msg);
            Console.WriteLine("Temperatura atual: " + temp);
        }
    }
}
