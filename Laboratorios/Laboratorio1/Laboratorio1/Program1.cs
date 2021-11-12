using System;
namespace Laboratorio1
{
    class Program
    {
        static void Main(String[] args)
        {

            System.Console.WriteLine("Alô Mundo!");
            System.Console.ReadLine();


            // Método Clear
            Console.Clear();


            // Propriedade Background Color - Mudar a cor do console
            System.Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Console.BackgroundColor ");
            // Métodos ResetColor
            Console.ResetColor();


            //Propriedade mudar a cor do texto do terminal
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Console.ForegroundColor");
            Console.ResetColor();


            //Propriedade BufferHeight e BufferWidth
            Console.WriteLine("The current buffer height is {0} rows.",
                     Console.BufferHeight);
            Console.WriteLine("The current buffer width is {0} columns.",
                              Console.BufferWidth);


            //Métodos Read e Readline
            Console.WriteLine("Escreva uma letra");
            Console.Read();
            Console.WriteLine("Console.Read()");

            Console.WriteLine("Escreva uma letra");
            Console.ReadLine();
            Console.WriteLine("Console.Read()");


            //Propriedade CapsLock
            if (Console.CapsLock == true)
                Console.WriteLine("CapsLock ON");
            else
                Console.WriteLine("CapsLock OFF");

            Console.WriteLine("Digite um número");
            Console.ReadLine();


            //Propriedade NumberLock
            if (Console.NumberLock == true)
                Console.WriteLine("NUM LOCK está atividado");
            else
                Console.WriteLine("NUM LOCK está desativado");


            //Método WriteLine e Write -diferença
            Console.WriteLine("Bem");
            Console.WriteLine("Vindo");

            Console.Write("Bem");
            Console.Write("Vindo");


            // Método  WriteLine
            Console.WriteLine();

            Console.WriteLine("Escreva alguma coisa");
            Console.Read();

       

        }
    }
}
