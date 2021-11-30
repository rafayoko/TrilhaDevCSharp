using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq
{
   internal class Program
   {
      static void Main(string[] args)
      {
         List<Pessoa> pessoas = new List<Pessoa>
         {
            new Pessoa{Nome="Ana", DataNascimento=new DateTime(1980,3,14), Casada=true},
            new Pessoa{Nome="Paulo", DataNascimento=new DateTime(1978,10,23), Casada=false},
            new Pessoa{Nome="Ana Maria", DataNascimento=new DateTime(1980,3,14), Casada=false},
            new Pessoa{Nome="Carlos", DataNascimento=new DateTime(1999,12,12), Casada=true},
            new Pessoa{Nome="Pedro", DataNascimento=new DateTime(1970,5,27), Casada=false},
            new Pessoa{Nome="Huginho", DataNascimento=new DateTime(1970,5,27), Casada=true},
            new Pessoa{Nome="Zezinho", DataNascimento=new DateTime(1980,3,17), Casada=false},
            new Pessoa{Nome="Luizinho", DataNascimento=new DateTime(1990,7,7), Casada=false}
         };

         //Consulta tradiconal
         List<Pessoa> resultado1 = new List<Pessoa>();
         foreach (Pessoa p in pessoas)
         {
            if (p.Casada)
               resultado1.Add(p);
         }
         Console.WriteLine("Pessoas casadas, consulta tradiconal:");

         foreach (Pessoa p in resultado1)
         {
            Console.WriteLine(p.Nome);
         }

         //Consulta LINQ
         var resultado2 = from p in pessoas
                          where p.Casada
                          select p;
         Console.WriteLine("\nPessoas casadas, consulta linq:");

         foreach (Pessoa p in resultado2)
         {
            Console.WriteLine(p.Nome);
         }

         Console.WriteLine("\nPessoas casadas, consulta linq (method syntax):");
         var resultado3 = pessoas.Where(p => p.Casada);

         foreach (Pessoa p in resultado3)
         {
            Console.WriteLine(p.Nome);
         }

         // para obter uma "lista" a partir da consulta linq
         var resultado4 = (from p in pessoas
                           where p.Casada
                           select p).ToList();


         Console.WriteLine("\nPessoas casadas que nasceram após 01/01/1980");
         var resultado5 = (from p in pessoas
                           where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
                           select p).ToList();

         // ups! forçando um pouco a barra...
         resultado5.ForEach(p => Console.WriteLine(p));

         Console.WriteLine("\nProjeção sobre o nome das pessoas casadas");
         var resultado6 = from p in pessoas
                          where p.Casada
                          select p.Nome;

         foreach (String s in resultado6)
         {
            Console.WriteLine(s);
         }

         Console.WriteLine("\nSoteiros em uma lista de objetos anonimos..");
         var resultado7 = (from p in pessoas
                           where !p.Casada
                           select new { p.Nome, p.DataNascimento }).ToList();

         foreach (var elem in resultado7)
         {
            Console.WriteLine(elem.Nome + " " + elem.DataNascimento);
         }

         Console.WriteLine("\nPessoas agrupadas pelo estado civil");
         var resultado8 = from p in pessoas
                          group p by p.Casada;
         foreach (var g in resultado8)
         {
            Console.WriteLine($"casado:{g.Key}");
            foreach (var p in g)
            {
               Console.WriteLine(p);
            }
         }

         Console.WriteLine("\nPessoa mais nova");
         var resultado9 = pessoas.Min(p => p.DataNascimento);
         //Console.WriteLine("Consulta 9:");
         //Console.WriteLine(resultado9);

         var resultado10 = (from p in pessoas
                            where p.DataNascimento == resultado9
                            select p.Nome).ToList();

         resultado10.ForEach(x => Console.WriteLine(x));

         Console.WriteLine("--------------------------------");

            /*3. Construa uma consulta que retorne as pessoas agrupadas pelo mês de nascimento e apresente-as em ordem crescente 
                de mês. Em um mesmo mês as pessoas devem ser listadas em ordem crescente de data de nascimento. Apresente o 
            número de pessoas que fazem aniversário em cada um dos meses. Execute e teste.
            */
            Console.WriteLine("Pessoas agrupadas pelo mês de nascimento e apresenta-las em ordem crescente: ");


            var resultado19 = (from p in pessoas
                               orderby p.DataNascimento.Month
                               select p).ToList();
                     

            resultado19.ForEach(x => Console.WriteLine(x));



            /*
        4. Construa uma consulta que retorne a pessoa mais velha. Execute e teste.*/
            Console.WriteLine("\nPessoa mais velha");
            var resultado12 = pessoas.Min(p => p.DataNascimento);
            var resultado13 = (from p in pessoas
                               where p.DataNascimento == resultado12
                               select p.Nome).ToList();

            resultado13.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("--------------------------------");
            /* 5. Construa uma consulta que retorne a pessoa solteira mais nova. Execute e teste.*/
            Console.WriteLine("\nPessoa solteira mais nova: ");

            var resultado14 = (from p in pessoas
                              where !p.Casada
                              select p).ToList();

            var resultado15 =  resultado14.Max(p => p.DataNascimento);
      
            var resultado16 = (from p in pessoas
                               where !p.Casada && p.DataNascimento == resultado15
                               select p.Nome).ToList(); 
            resultado16.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("--------------------------------");


            /*6. Construa uma consulta que retorne a idade média das pessoas, em anos. Execute e teste
            */

            var resultado17 = pessoas.Average(c => c.DataNascimento.Year);
            var resultado18 = Convert.ToInt32(resultado17);
            Console.WriteLine(resultado18);



        }
    }
}
