using System;

namespace Laboratorio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 Trabalhando com tipos-valor fundamentais byte, int e long

            //2. Dentro do método Main, crie uma variável local do tipo byte com o nome b.
            //No início do método Main, digite o seguinte:
            byte b;

            //3. Coloque o valor inicial da variável como o valor máximo que pode ser armazenado em um byte.
            b = byte.MaxValue;

            //4. Mostre o resultado na janela de console:
            Console.WriteLine("Valor maximo de byte: " + b);

            //5. Dentro do método Main, crie uma variável local do tipo int com o nome i.
            int i;

            //6. Coloque o valor inicial da variável como o valor máximo que pode ser armazenado em um int.
            i = int.MaxValue;

            //7. Mostre o resultado na janela de console:
            Console.WriteLine("Valor maximo de int: " + i);

            //8. Dentro do método Main, crie uma variável local do tipo long com o nome l.
            long l;

            // 9. Coloque o valor inicial da variável como o valor máximo que pode ser armazenado em um long. 
            l = long.MaxValue;

            //10. Mostre o resultado na janela de console:
            Console.WriteLine("Valor maximo de long: " + l);


            // 2 Trabalhando com strings 

            //1. Crie duas strings como mostrado abaixo:
            string strPrimeira = "Alo ";
            string strSegunda = "Mundo";

            //2. Crie uma terceira string e a inicialize com o resultado da concatenação das duas strings anteriores:
            string strTerceira = strPrimeira + strSegunda;

            //3. Mostre o resultado na janela de console: 
            Console.WriteLine(strTerceira);

            //4. Calcule o tamanho da string strTerceira utilizando o seguinte código:
            int cchTamanho = strTerceira.Length;

            //5. Crie uma string para guardar o resultado da seguinte forma:
            string strQuarta = "Tamanho = " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);

            //6. Chame o método String.Substring para remover uma parte de uma string. Mostre o resultado: 
            Console.WriteLine(strTerceira.Substring(0, 5));

            //3 Trabalhando com objetos do Framework

            //1. Para criar um objeto DateTime é necessário chamar o operador new, como no seguinte código: 
            DateTime dt = new DateTime(2015, 04, 23);

            //2. Como os demais tipos, a classe DateTime possui um método ToString para converter o objeto para uma 
            //string, como mostrado abaixo:
            string strQuinta = dt.ToString();

            //3. Mostre o resultado da seguinte maneira:
            Console.WriteLine(strQuinta);



            //4 Exercícios

            // 1.Além de tipos inteiros, C# também suporta float, double, e decimal o qual garante uma boa precisão para 
            //trabalhos com valores monetários. Escreva algum código para testar variáveis destes novos tipos e mostrar o
            // resultado na tela do console.
            int num = 2;
            Console.WriteLine(num);
            num = int.MinValue;
            Console.WriteLine(num);

            double num2 = 2.4525;
            Console.WriteLine(num2);

            sbyte num3 = 127;
            Console.WriteLine(num3);
            System.SByte num4 = -128;
            Console.WriteLine(num4);

            long num5 = 555254;
            Console.WriteLine(num5);
            System.Int64 num6 = 1253565L;
            Console.WriteLine(num6);

            float num7 = 7.5f;
            Console.WriteLine(num7);

            decimal num8 = 65635;
            Console.WriteLine(num8);

            bool teste = false;
            Console.WriteLine(teste);
            char teste1 = 'F';
            Console.WriteLine(teste1);
            char letra = '\u0042';
            Console.WriteLine(letra);

      


            //2.Busque na documentação da biblioteca de classes do .Net Framework ou .Net Core, novas operações da classe 
            //String.Faça experiências e mostre os resultados na tela. 

            string nome = "Rafaela Yoko";
            Console.WriteLine(nome);

            string frase = "Oi, tudo bem?";
            Console.WriteLine(frase);

            char[] chars = { 'B', 'O', 'M', ' ', 'D', 'I', 'A' };
            string string1 = new string(chars);
            Console.WriteLine(string1);

            string string2 = new string('A', 20);
            Console.WriteLine(string2);

            string string3 = "Data de hoje :" + DateTime.Now.ToString("f") + ".";
            Console.WriteLine(string3);

            string string4 = "Primeira frase " + "Segunda frase ";
            string4 +=  "Terceira frase ";
            Console.WriteLine(string4);


            //3. Busque na documentação da biblioteca de classe do .Net Framework ou .Net Core, novas operações 
            //da classe DateTime.Faça experiências e mostre os resultados na tela

            var data1 = new DateTime(2050, 11, 1, 15, 00, 00);
            Console.WriteLine(data1);

            var data2 = new DateTime();
            Console.WriteLine(data2.ToString(System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine(data2.Equals(DateTime.MaxValue));

            //Data e hora atuais
            DateTime date1 = DateTime.Now;
            Console.WriteLine(date1);
            //Data e hora UTC (hora universal)
            DateTime date2 = DateTime.UtcNow;
            //Data atual
            Console.WriteLine(date2);
            DateTime date3 = DateTime.Today;
            Console.WriteLine(date3);

            //4. Converter dados em C# se dá de forma implícita ou explícita. Digite o seguinte exemplo e note que 
            //a conversão para um tipo “maior” é feita de forma implícita e, para um tipo “menor” de forma explícita.

            int x = 10;
            float f = 0;
            f = x; //conversão implícita, sem perda de dados. 
            System.Console.WriteLine(f);
            f = 0.5F;
            x = (int)f; //conversão explícita, com perda de dados. 
            System.Console.WriteLine(x);

            //5. Além das conversões realizadas pela linguagem C#, podemos utilizar um mecanismo fornecido pelo 
            //próprio Framework, que é independente da linguagem utilizada.Este mecanismo é a classe System.Convert.
            //Escreva um programa para testar os diferentes métodos de conversão. Como exemplo, utilize as seguintes
            //linhas de comandos:

            string stringInteir = "123456789";
            int valorStringInteir = Convert.ToInt32(stringInteir);
            Console.WriteLine(valorStringInteir);
            Int64 valorInt64 = 123456789;
            int valorInt = Convert.ToInt32(valorInt64);
            Console.WriteLine(valorInt);


            UInt32 valorInt32 = 511444212;
            string stringvalorInt32 = Convert.ToString(valorInt32);
            Console.WriteLine(stringvalorInt32);

            float valorfloat = 51.2f;
            int valorint = Convert.ToInt32(valorfloat);
            Console.WriteLine(valorint);


            //Adicione agora as seguintes linhas ao seu programa

            //string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            //int valorStringInteiroGrande = Convert.ToInt32(stringInteiroGrande);

            //Note que ao tentar converter uma string com um valor que irá estourar a capacidade máxima que o tipo Int32 
            //suporta a seguinte exceção será gerada: 

            /*Da mesma forma ao tentar converter uma string contendo letras ao invés de algarismos outra exceção será 
            gerada.Para que isto não aconteça em uma conversão de tipos, o .NET Framework 2.0 trouxe o método
           TryParse para os tipos valor, que retorna um boolean com o valor true caso a operação tenha sido bem
            sucedida, ou com o valor false caso contrario.
            */

            // 6.Escreva um programa para testar o método TryParse.Como exemplo, utilize as seguintes linhas de
            //comandos:

            string stringInteiro = "123456789";
            int valorStringInteiro;
            bool conversao1 = Int32.TryParse(stringInteiro, out valorStringInteiro);
            Console.WriteLine("Conversão efetuada:" + conversao1 + " Valor: " + valorStringInteiro);

            string stringInteiroGrande = "999999999999999999999999999999999999999999999";
            int valorStringInteiroGrande;
            bool conversao2 = Int32.TryParse(stringInteiroGrande, out valorStringInteiroGrande);
            Console.WriteLine("Conversão efetuada:" + conversao2 + " Valor: " + valorStringInteiroGrande);
            string stringLetras = "abc";
            double valorStringLetras;
            bool conversao3 = Double.TryParse(stringLetras, out valorStringLetras);
            Console.WriteLine("Conversão efetuada:" + conversao3 + " Valor: " + valorStringLetras);



            string stringdosnumeros = "0405231562356325456231553322222548";
            sbyte valorsbytedosnumeros;
            bool converter = sbyte.TryParse(stringdosnumeros, out valorsbytedosnumeros);
            Console.WriteLine("A conversão foi efetuada?: " + converter + "     Resultado:  " + valorsbytedosnumeros);

            string stringdosnumeros2 = "3265625156156151561.515615615645645611456156156";
            double valordoubledosnumeros;
            bool converter2 = double.TryParse(stringdosnumeros2, out valordoubledosnumeros);
            Console.WriteLine("A conversão foi efetuada?: " + converter2 + "    Resultado:  "+ valordoubledosnumeros);


            //7. Devemos ter muito cuidado com os métodos de conversão de valores, pois arredondamentos são 
            //executados de formas diferentes. Verifique o comportamento do seguinte trecho de código.

            double valorFracionado = 4.7;
            int valorInteiro1 = (int)valorFracionado;
            int valorInteiro2 = Convert.ToInt32(valorFracionado);
            Console.WriteLine("Conversao explicita = " + valorInteiro1);
            Console.WriteLine("Conversao metodo Convert = " + valorInteiro2);

            //COMENTÁRIO: Nota-se que na conversão explicita, perde os valores após a vírgula~.
            //             No metodo Convert o valor após a vírgula tem relevância. Fazendo um teste com valofracionado = 4.4
            //              o resultado da conversão por metodo Convert = é 4.

            //8.O comando WriteLine tem uma sintaxe específica para a exibição de valores de várias variáveis. Teste
            //o trecho abaixo. Explique como o mesmo funciona.

            int z = 10;
            double y = 3.4;
            Console.WriteLine("{0} {1}", z, y);

            /* Explicando: o primeiro parâmetro entre chaves é 0, indica que o indice é 0 e corresponde a referencia a 
             primeira variável digitada no Console.WriteLine, 
             o segundo parâmento entre chave {1} indica que o indice é um, e corresponde a segunda variável digitada no Console.WriteLine.
             É possível também formatar os os valores númericos em vários formatos, como por exemplo: em hexadecimal, científico, e numérico
            exemplo: {0:E} {0:N}
            */
            int w = 156550;
            double u = 3.45545645452;
            Console.WriteLine("{0:E} {1:N}", w, u);




        }
    }
}
