using System;

namespace Laboratorio5
{
    class Program
    {
        static void Main(string[] args)
        {

            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            CirculoColorido circ3 = new CirculoColorido();
            Console.WriteLine(circ3);
            CirculoColorido circ4 = new CirculoColorido(1.5, 3.1, 1, "vermelho");
            Console.WriteLine(circ4);


            /*1. Altere o método Main para mostrar o uso das propriedades do círculo e círculo colorido. É 
        possível utilizar as propriedades CentroX e CentroY em um objeto da classe CirculoColorido?*/

            
            Console.WriteLine("Propriedade círculo CentroX: " + circ1.CentroX);
            Console.WriteLine("Propriedade círculo CentroY: " + circ1.CentroY);
            Console.WriteLine("Propriedade círculo Raio: " + circ1.Raio);

            Console.WriteLine();

            Console.WriteLine("Propriedade círculo colorido: " + circ3.Cor);

            CirculoColorido circ6 = new CirculoColorido();

            Console.WriteLine(" Utilizando propriedades Centro X e centro Y em um objeto da classe CirculoColorido : " + circ6.CentroX + " ; " + circ6.CentroY+ " ; " + circ6.Raio+ " ; " +  circ6.Cor);;
            //É possível utilizar as propriedades CentroX e CentroY em um obejto da classe CircuoColorido, porém o contrário não é verdadeiro? Pois testando usar a propriedade da Cor no objeto do Circulo, dá um erro.)

            Console.WriteLine("-------------------------------------");

            /*2. Crie uma subclasse de CirculoColorido chamada CirculoColoridoPreenchido que possui uma cor 
            adicional para o preenchimento do círculo. Utilize um objeto mais adequado para armazenar a cor do que 
            uma string (procure na API do .NET por essa classe!). Teste a classe criada. */

            CirculoColoridoPreenchido circ7 = new CirculoColoridoPreenchido();
            Console.WriteLine(circ7);


            /*3. Crie uma array de objetos do tipo Circulo e a preencha com instâncias de Circulo, 
            CirculoColorido e CirculoColoridoPreenchido. A seguir, percorra o array e imprima no console os dados 
            de cada um dos objetos.
            */

          Circulo [] Array = new Circulo[2];
          Array [0] = new Circulo();
          Array [1] = new CirculoColorido();
          Array[2] = new CirculoColoridoPreenchido();

            for (int i=0; i< Array.Length ; i++){
                Console.WriteLine(Array[i]);
            }


           



        }
    }
}
