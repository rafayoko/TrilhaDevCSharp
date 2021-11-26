using System;
using System.Collections.Generic;

namespace Laboratorio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lista = { "Gustavo", "Danilo", "Matheus", "Odin" };
            Console.WriteLine("Array antes da ordenacao");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }
            Console.WriteLine("------------------");


            Array.Sort(lista);
            Console.WriteLine("Array depois da ordenacao");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.Write(lista[i] + " ");
            }

            Console.WriteLine("------------------------------------");

            Console.WriteLine();


            Pessoa[] lista2 = {new Pessoa("Jose", 25), new Pessoa("Ana", 28),new Pessoa("Paulo", 20)};
            Array.Sort(lista2);
            Console.WriteLine("Array depois da ordenacao");

          
            for (int i = 0; i < lista2.Length; i++)
            {
                Console.Write(lista2[i].Nome + " ");
               
            }

            Console.WriteLine("--------------------------------------------");

            //Você conseguiria criar uma classe Pessoa que permitisse ordenar ora por nome, 
            //ora pela idade, utilizando a interface IComparable?
            
            Pessoa2[] lista3 = { new Pessoa2("Jose", 25), new Pessoa2("Ana", 28), new Pessoa2("Paulo", 20) };
            
            Console.WriteLine("Você quer ordenar por Nome ou por Idade? (1/2)");
            
                int resp = int.Parse(Console.ReadLine());

            Pessoa2 p = new Pessoa2();

            p.Resposta = resp;
          
            Array.Sort(lista3);
            for (int i = 0; i < lista2.Length; i++)
            {

                Console.Write(lista3[i].Nome + " ");
               

            }

            /*   3.Existe outra interface que poderia ser utilizada para resolver a questão da ordenação? Qual? Mostre como
     ficaria a solução. */

            //Sim, existe o IComparare

            Pessoa3[] lista4 = { new Pessoa3("Jose", 25), new Pessoa3("Ana", 28), new Pessoa3("Paulo", 20) };
        


            Array.Sort(lista4);
            //lista4.Sort(new Pessoa3());
            // Array[].Sort(new Pessoa3());
            for (int i = 0; i < lista4.Length; i++)
            {

                Console.Write(lista3[i].Nome + " ");


            }

        }


    }
}
