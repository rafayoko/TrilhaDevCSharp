using System;

namespace Laboratorio3
{
    class Program
    {
        private const string V = "Tres";

        static void Main(string[] args)
        {

            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i;
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }

            Console.WriteLine();

            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

            Console.WriteLine();


            DateTime[] dt = new DateTime[2];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            for (iDate = 0; iDate < 2; iDate++)
            {
                Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
            }

            Console.WriteLine();

            // 8.Reescreva estes laços de “for” usando o comando “foreach”. 

            Console.WriteLine("Rescrevendo os laços de 'for' usando o comando 'foreach'");

            int[] array2 = new int[5] { 10, 20, 30, 40, 50 };
            i = -1;
            foreach (int num in array2)
            {
                i++;
                Console.WriteLine("Indice = " + i + " & Valor = " + num);
            }

            Console.WriteLine();


            string[] str2 = new string[3];
            str2[0] = "Um";
            str2[1] = "Dois";
            str2[2] = "Três";
            foreach (string strings3 in str2)

            {

                i++;
                Console.WriteLine("Indice = " + i + " & Valor = " + strings3);
            }

            Console.WriteLine();

            DateTime[] dt2 = new DateTime[2];
            int iDate2 = -1;
            dt2[0] = new DateTime(2002, 5, 1);
            dt2[1] = new DateTime(2002, 6, 1);


            foreach (DateTime obj in dt2)
            {
                iDate2++;
                Console.WriteLine("Indice = " + iDate2 + " & Data = " + dt2[iDate2].ToShortDateString());

            }

            Console.WriteLine();

            /* 4 Exercícios
             1.Faça um programa que crie dois arrays de tamanho iguais de números inteiros(digamos 100 elementos
             cada). Popule um dos arrays com diversos valores e deixe o outro array vazio.Agora, realize a cópia dos
             elementos do primeiro array para o segundo. 
            */
            Console.WriteLine("Dois arrays de números inteiros");

            int[] array3 = new int[100];
            int[] array4 = new int[100];
            Random numaleatorio = new Random();
            for (int x = 0; x < 100; x++)
            {
                array3[x] = numaleatorio.Next(0, 99);
                Console.Write(" " + array3[x] + " ");
            }

            Console.WriteLine();


            for (int x = 0; x < 100; x++)
            {
                array4[x] = array3[x];
                Console.Write(" " + array4[x] + " ");




            }

            Console.WriteLine();

            /*
            2.Escreva um programa que crie uma matriz de valores inteiros(5x5) e retorne o valor da soma de cada
            coluna.Apresente duas versões para o programa: array multidimensional e array jagged.
            */


            Console.WriteLine("Matriz de valores inteiros(5x5) e soma de cada coluna : ");

            int[,] matriz5x5 = new int[5, 5];
            Random naleatorio = new Random();
            for (int a = 0; a < 5; a++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz5x5[a, j] = naleatorio.Next(0, 3);
                    Console.Write(" " + matriz5x5[a, j] + " ");

                }

                Console.WriteLine();
            }
            int[] vet = new int[5];
            for (int j = 0; j < 5; j++)
            {

                for (int a = 0; a < 5; a++)
                {
                    vet[a] = vet[a] + matriz5x5[j, a];

                }

            }
            for (int v = 0; v < 5; v++)
            {
                Console.WriteLine("Coluna " + (v+1)  + ": " + vet[v]);
            }

            Console.WriteLine();



            int[][] jArray = new int[4][];
            jArray[0] = new int[4] { 1, 2, 3, 5 };
            jArray[1] = new int[4] { 4, 2, 3, 5 };
            jArray[2] = new int[2] { 1, 3 };
            jArray[3] = new int[1] { 1 };
            jArray[4] = new int[4] { 1, 2, 3, 4 };

            for (int w = 0; w >jArray.Length; w++)
            {
                for (int l = 0; l > jArray[w].Length; l++)
                {
                    Console.Write(" " + jArray[w][l] + " ");
                }
            }

            Console.WriteLine();





            // Esse aqui com os números aleatórios não está rodando.
            /*
            int[][] jArray = new int[4][];
            jArray[0] = new int[4];
            jArray[1] = new int[4];
            jArray[2] = new int[4];
            jArray[3] = new int[4];
            jArray[4] = new int[4];

            for (int w = 0; w < jArray.Length; w++)
            {
                for (int l = 0; l < jArray[w].Length; l++)
                {
                    jArray[w][l] = naleatorio.Next(0, 5);
                    Console.Write(" " + jArray[w][l] + " ");
                }
            }

            int[] vet2 = new int[5];
            for (int j = 0; j < 5; j++)
            {

                for (int a = 0; a < 5; a++)
                {
                    vet2[a] = vet2[a] + jArray[a][j];

                }

            }
            for (int v = 0; v < 5; v++)
            {
                Console.WriteLine("Coluna " + v + 1 + ": " + vet2[v]);
            }
            */

        }

    }
}