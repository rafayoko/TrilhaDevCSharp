using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio8
{
    public class Pessoa2 : IComparable<Pessoa2>
    {
        private string nome;
        private int idade;
        public int resposta;


        public Pessoa2(){
            }
        public Pessoa2(string n, int t, int resp)
        {
            nome = n;
            idade = t;
            resposta = resp;

        }

        public int Resposta
        {
           get { return resposta; }
            set { resposta = value; }
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

        public int CompareTo(Pessoa2 outro)
        {
            if(this.resposta == 1)
            {
                return Nome.CompareTo(outro.Nome);
            }
            else
            {
                return Idade.CompareTo(outro.Idade);
            }
        }

       
    }
           

       
    }
