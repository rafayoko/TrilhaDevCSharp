using System;
using System.Collections.Generic;

namespace Laboratorio6
{
    class Program
    {

        static void Main(string[]args)
        {
            /*  1.Escreva um programa que crie vários tipos de conta e teste cada um dos métodos e propriedades
         desenvolvidos.   */

            ContaPoupanca cp = new ContaPoupanca("", 0);
            List<Conta> listConta = new List<Conta>();

            Console.WriteLine("Deseja cadastrar uma conta? (s/n)");
            char cadastro = char.Parse(Console.ReadLine());

            while (cadastro == 's')
            {
                Console.WriteLine("Qual o nome do Titular? ");
                string nometitular = Console.ReadLine();

                Console.WriteLine("Qual o  depósito inicial? ");
                decimal depoinicial = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite '1' para Conta Corrente ou '2' Conta Poupança?");
                bool tipoDeConta = int.Parse(Console.ReadLine()) == 1 ? true : false;

                if (tipoDeConta)
                {
                    listConta.Add(new ContaCorrente(nometitular, depoinicial));
                }
                else
                {
                    Console.WriteLine("Qual a taxa de juros?");
                    decimal taxadejurosconta = decimal.Parse(Console.ReadLine());
                    DateTime datadeniver = DateTime.Now;
                    cp.AdicionarRendimento();
                    listConta.Add(new ContaPoupanca(taxadejurosconta, datadeniver, nometitular, depoinicial));
                }

                foreach (Conta ac in listConta)
                {
                    Console.WriteLine(ac.Titular + "  " + ac.Saldo + "  " + ac.Id);
                }


                Console.WriteLine("Deseja cadastrar outra conta? (s/n)");
                cadastro = char.Parse(Console.ReadLine());
            }

            //Operações

            Console.WriteLine("Deseja fazer alguma operação de saque ou depósito? (s/n)");
            char operacaoSouD = char.Parse(Console.ReadLine());

            while (operacaoSouD == 's')
            
                {

                    Console.WriteLine("Qual o nome do titular?");
                    string nomeDoTitular = Console.ReadLine();

                    Console.WriteLine("Sacar ou Depositar? (s/d)");
                    bool saqueoudeposito = char.Parse(Console.ReadLine()) == 's' ? true : false;
                    if (saqueoudeposito)
                    {
                        Console.Write("Qual o valor do saque?");
                        decimal valsaque = decimal.Parse(Console.ReadLine());

                        foreach (var item in listConta)
                        {
                            if (item.Titular == nomeDoTitular)
                            {
                                item.Sacar(valsaque);
                            }
                        }
                    }
                    else
                    {
                        Console.Write("Qual o valor do depósito?");
                        decimal valdeposito = decimal.Parse(Console.ReadLine());

                        foreach (var item in listConta)
                        {
                            if (item.Titular == nomeDoTitular)
                            {
                                item.Depositar(valdeposito);
                            }
                        }
                    }

                    Console.WriteLine("Deseja fazer alguma operação de saque ou depósito? (s/n)");
                    operacaoSouD = char.Parse(Console.ReadLine());
                }

            

            foreach (Conta item in listConta)
            {
                Console.WriteLine("Nome do Titular :   " + item.Id + ";   Saldo da Conta:   " + item.Saldo);
            }

            Console.WriteLine("-----------------------------------------");

            foreach (Conta item in listConta)
            {
                Console.WriteLine("Nome do Titular :   " + item.Id + " ;     Saldo da Conta: " + item.Saldo);
            }
            Conta[] arrayConta = new Conta[4];

            DateTime hoje = DateTime.Now;
            arrayConta[0] = new ContaPoupanca(1000, hoje, "Rafa", 2);
            arrayConta[1] = new ContaPoupanca(1, hoje, "Rafa", 100);
            arrayConta[2] = new ContaCorrente("Rafa", 100);
            arrayConta[3].Sacar(100);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(arrayConta[i].Id);
                Console.WriteLine(arrayConta[i].Saldo);
            }

        }


        /*
        2.Crie uma coleção de objetos do tipo Conta e acrescente diversos objetos dos tipos das classes
        derivadas.Quais métodos podem ser chamados sobre os elementos da coleção?*/




}




}







