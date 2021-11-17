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

            /*1. Altere a classe ContaCorrente de forma que ela possua atributos para armazenar a data de criação da 
            conta e o nome do titular. O nome do titular deve ser informado como parâmetro do construtor. A data de 
            criação deve ser gerada no momento da inicialização (DateTime.Now). Crie também propriedades de acesso a 
            estes atributos. 
             */
            Console.WriteLine("Digite o nome");
            minhaConta.Nome = Console.ReadLine();
            Console.WriteLine(minhaConta.Nome);
            Console.WriteLine(minhaConta.Dataehora);


            /*2. Altere a classe ContaCorrente de maneira que ela seja capaz de armazenar o saldo médio do 
            correntista. Para tanto, cada vez que os métodos de depósito ou retirada forem acionados o saldo da conta, 
            depois da operação, deve ser acumulado e um contador deve ser incrementado. O saldo médio é obtido 
            dividindo-se este acumulador pelo número de operações realizadas. 
            */
            Console.WriteLine(minhaConta.SaldoMedio);

            /*3. Escreva um programa que instancia uma conta corrente, executa uma série de operações de depósito 
                e retirada e, por fim, imprime o saldo médio da conta. 
            */
            Console.WriteLine("Quantas operações de depósito você vai realizar?");
            int n = Console.ReadLine();
                for ( int i = n; i>0; i--)
            {
                Console.WriteLine("Qual valor do depósito?");
                minhaConta.Depositar(val) = Console.ReadLine();
  
            }

     
        Console.WriteLine("Quantas operações de saque você vai realizar?");
            int m = Console.ReadLine();
            for (int i = m; i > 0; i--)
            {
                Console.WriteLine("Qual valor do saque?");
                minhaConta.Sacar(val) = Console.ReadLine();
            }

            Console.WriteLine(minhaConta.SaldoMedio);

        }
    }
}
