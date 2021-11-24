using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            1.Escreva um programa que crie vários tipos de conta e teste cada um dos métodos e propriedades
            desenvolvidos.

           */

            Console.WriteLine("Deseja cadastrar uma conta? (s/n)");
            char cadastro = char.Parse(Console.ReadLine());

            while (cadastro == 's')
            {
               
                Console.WriteLine("Qual o nome do Titular? ");
                string nometitular = Console.ReadLine();

                Console.WriteLine(" Qual o  depósito inicial? (s/n)");
                decimal depoinicial = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Qual a taxa de juros?");
                decimal taxadejurosconta = decimal.Parse(Console.ReadLine());
                ContaPoupanca cp = new ContaPoupanca(nometitular, taxadejurosconta);

                DateTime datadeniver = DateTime.Now;
                
                List<Conta> list = new List<Conta>();
                list.Add(new ContaPoupanca(taxadejurosconta, datadeniver, nometitular, depoinicial));

                foreach (Conta ac in list)
                {
                    Console.WriteLine("Dados:" + ac.Titular) ;
                }



                Console.WriteLine("Deseja cadastrar outra conta? (s/n)");
                cadastro = char.Parse(Console.ReadLine());
            }




            /*
            2.Crie uma coleção de objetos do tipo Conta e acrescente diversos objetos dos tipos das classes
            derivadas.Quais métodos podem ser chamados sobre os elementos da coleção?*/


                }
    }
}
