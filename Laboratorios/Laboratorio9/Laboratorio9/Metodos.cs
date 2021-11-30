using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Laboratorio9
{
    class Metodos
    {

        public int contador;
       
        List<int> lista3 = new List<int>();
        public int TotalAcimaMedia(List<int> list2 )
        {

            int somar = list2.Sum();
            decimal media = somar / list2.Count;

            foreach ( int obj in list2)
            {
                if( obj > media)
                {
                    contador += 1;
                }
            }
            return contador;
        }

        public List<int> ListaAcimaMedia(List <int> list2)
        {
            int somar = list2.Sum();
            decimal media = somar / list2.Count;
            
            foreach (int obj2 in list2)
            {
                contador = 0;
                
                if (obj2 > media)
                {
                 
                    for(int i = 0; i < contador; i++)
                    {
                        lista3.Add(obj2);
                    }
                }  
            }
           
            return lista3;
        }
    }
}

