using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Laboratorio8
{
    public class Pessoa3 : IComparer<Pessoa3>
    {
        private string nome;
        private int idade;

        public Pessoa3()
        {
        }

        public Pessoa3(string n, int t)
        {
            nome = n;
            idade = t;

        }
     

        public String Nome
        {
            get { return nome; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public int Compare(Pessoa3 x, Pessoa3 y)
        {
            if(x.Idade > y.Idade)
            {
                return 1;
            }
            else if (x.Idade < y.Idade)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }


    }
}
