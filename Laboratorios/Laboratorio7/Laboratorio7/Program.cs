using System;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            IEstadoBinario[] lista = new IEstadoBinario[4];
            lista[0] = new Lampada(110, 60);
            lista[0].Ligar();
            lista[1] = new TermometroEletrico();
            lista[2] = new CarroEletrico(50);
            lista[3] = new CarroEletrico(0);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(lista[i].Estado);
            }
        }
    }
}