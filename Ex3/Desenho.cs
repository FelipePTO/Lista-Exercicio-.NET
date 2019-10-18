
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesenhoModel{
    public class Desenho {

        

        public int Id {get;set;}
        public string Nome {get;set;}
        public int Peso {get;set;}
        public Desenho[] Filhos {get;set;}
        

        public string FilhosEmOrdem(){

            Dictionary<string, int> listaordem = new Dictionary<string, int>();
            string listaordenada = "";
            if(Filhos != null){
                foreach(var i in Filhos){
                    listaordem.Add(i.Nome, retornaPesodoFilho(i.Filhos));
                }

                var lista = (listaordem.OrderByDescending(x=>x.Value)).Select(x=>x.Key).ToList();
                
                    listaordenada+="Filhos em ordem: ";
                foreach(var i in lista){
                    listaordenada+=i;
                    listaordenada+=" ";
                }

            }


            return listaordenada;
        }

        public virtual int retornaPeso(){

            int pesoTotal = 0;
            pesoTotal+=retornaPesodoFilho(Filhos);            
            pesoTotal+=Peso;
            return pesoTotal;

        }


        //Função que utiliza a recorrência para percorrer os filhos dos filhos
        public int retornaPesodoFilho(Desenho[] Filhos){
            int pesoTotal=0;
            if(Filhos != null){
                foreach(var k in Filhos){
                    pesoTotal += k.Peso;
                    if(k.Filhos != null){
                        pesoTotal += retornaPesodoFilho(k.Filhos);
                    }
                }
            }
            return pesoTotal;
        }

    }

}