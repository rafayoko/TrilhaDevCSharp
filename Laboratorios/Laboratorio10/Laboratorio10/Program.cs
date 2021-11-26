﻿using System;

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
            // aumentar a temperatura além do limite term.Aumentar(6); 
            Console.WriteLine(term.ToString());
            2.Adicione código para o tratamento de evento dentro da classe “Program”: 
private static void TrataLimiteSuperior(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    }
}
