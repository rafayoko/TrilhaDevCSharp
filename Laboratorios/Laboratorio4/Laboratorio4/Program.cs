using System;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente minhaConta = new ContaCorrente(340);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Depositar(100);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.Sacar(50);
            Console.WriteLine(minhaConta.Saldo);
            minhaConta.SaldoMedio();

            Console.WriteLine("------------------------");

            /*1. Altere a classe ContaCorrente de forma que ela possua atributos para armazenar a data de criação da 
            conta e o nome do titular. O nome do titular deve ser informado como parâmetro do construtor. A data de 
            criação deve ser gerada no momento da inicialização (DateTime.Now). Crie também propriedades de acesso a 
            estes atributos. 
             */
            Console.WriteLine("Digite o nome");
            minhaConta.Nome = Console.ReadLine();
            Console.WriteLine("Nome Correntista: " + minhaConta.Nome);
            Console.WriteLine("Saldo Atual : " + minhaConta.Saldo);
            Console.WriteLine(minhaConta.Dataehora());


            /*2. Altere a classe ContaCorrente de maneira que ela seja capaz de armazenar o saldo médio do 
            correntista. Para tanto, cada vez que os métodos de depósito ou retirada forem acionados o saldo da conta, 
            depois da operação, deve ser acumulado e um contador deve ser incrementado. O saldo médio é obtido 
            dividindo-se este acumulador pelo número de operações realizadas. 
            */
            Console.WriteLine("Saldo Médio: " + minhaConta.SaldoMedioo);


            /*3. Escreva um programa que instancia uma conta corrente, executa uma série de operações de depósito 
                e retirada e, por fim, imprime o saldo médio da conta. 
            */
         
            Console.WriteLine("Deseja fazer alguma operação? (1 para sim e -1 para nao)");
            int operacao = int.Parse(Console.ReadLine());

            while (operacao > 0)
            {
                Console.WriteLine("Você fará um depósito ou um saque?(d/s) ");
              string resposta = Console.ReadLine();
               
                if (resposta == "d")
                {
                    Console.WriteLine("Qual o valor do depósito?");
                    decimal valdeposito = decimal.Parse(Console.ReadLine());
                    minhaConta.Depositar(valdeposito);
                    minhaConta.SaldoMedio();
                    Console.WriteLine("Saldo: " + minhaConta.Saldo);
                    Console.WriteLine("Saldo Médio : " + minhaConta.SaldoMedioo);

                    Console.WriteLine("Deseja fazer mais alguma operação? (1 para sim e -1 para não");
                   operacao = int.Parse(Console.ReadLine());
                    
                }
                else 
                {

                    Console.WriteLine("Qual o valor do saque?");
                    decimal valsaque = decimal.Parse(Console.ReadLine());
                    minhaConta.Sacar(valsaque);
                    minhaConta.SaldoMedio();
                    Console.WriteLine("Saldo: " + minhaConta.Saldo);
                    Console.WriteLine("Saldo Médio : " + minhaConta.SaldoMedioo);

                    Console.WriteLine("Deseja fazer mais alguma operação? (1 para sim e -1 para não");
                    operacao = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("Fim das operações");
           
            }
        }
    }
