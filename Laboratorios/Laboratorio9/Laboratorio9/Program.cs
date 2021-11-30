using System;
using System.Collections.Generic;
using System.Linq;

namespace Laboratorio9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listaStrings = new List<string>();
            listaStrings.Add("Um"); listaStrings.Add("Hello");
            listaStrings.Add("World");
            Console.WriteLine(listaStrings[0]);
            Console.WriteLine(listaStrings[1]);
            Console.WriteLine(listaStrings[2]);

            //listaStrings.Add(10);

            Console.WriteLine("-----------------------------------------------");

            Queue<Object> q = new Queue<Object>();
            q.Enqueue(".Net Framework / Core");
            q.Enqueue(new Decimal(123.456));
            q.Enqueue(654.321);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine("-----------------------------------------------");

            Queue<int> minhaFila = new Queue<int>();
            minhaFila.Enqueue(10);
            minhaFila.Enqueue(200);
            minhaFila.Enqueue(1000);
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());
            Console.WriteLine(minhaFila.Dequeue());

            Console.WriteLine("---------------------------------------------------");

            Dictionary<int, string> paises = new Dictionary<int, string>();
            paises[44] = "Reino Unido";
            paises[33] = "França";
            paises[55] = "Brasil";
            Console.WriteLine("O código 55 é: {0}", paises[55]);
            foreach (KeyValuePair<int, string> item in paises)
            {
                int codigo = item.Key;
                string pais = item.Value;
                Console.WriteLine("Código {0} = {1}", codigo, pais);
            }
            //1. Como fazer para recuperar o código DDI a partir do nome de um país no exemplo de uso do Dicionário?

            var myKey = paises.FirstOrDefault(paises => paises.Value == "Brasil").Key;
            Console.WriteLine("O código do país Brasil é : " + myKey);

            /*2. Dada uma lista de números reais, implemente um método TotalAcimaMedia, para calcular e retornar o 
             número de elementos da lista cujos valores são maiores do que a média de todos os elementos.  */
            List<int> list2 = new List<int>();
            int[] numeros2 = new int[] { 1, 2, 3, 4, 5, 0 };
            list2.AddRange(numeros2);
            Metodos met = new Metodos();
            met.TotalAcimaMedia(list2);

            Console.WriteLine(met.contador);

            Console.WriteLine("-----------------------------");

            /*3. Você consegue imaginar uma forma de retornar uma nova lista com esses valores, ao invés de apenas 
           retornar o número de elementos? Crie o método ListaAcimaMedia.*/
            met.ListaAcimaMedia(list2);
            for (int i=0; i < list2.Count; i++)
            {
                Console.WriteLine(value: Metodos.lista3);

            }

           
            
           /* static decimal ListaAcimaMedia()
            {

                int somar = list2.Sum();
                decimal media = somar / numeros2.Length;
                foreach (int obj in list2)
                {
                    if (obj > media)
                    {
                        Console.WriteLine(obj);
                    }
                }
            } */
           // 18h56

        }


    }
}
