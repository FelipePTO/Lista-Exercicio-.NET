using System;
using System.Globalization;		
using System.Collections.Generic;

namespace DesenhoModel{
    public class Desenho {

        

        public int Id {get;set;}
        public string Nome {get;set;}
        public int Peso {get;set;}
        public Desenho[] Filhos {get;set;}
        


        public virtual int retornaPeso(){

            int pesoTotal = 0;
            pesoTotal+=retornaPesodoFilho(Filhos);            
            pesoTotal+=Peso;
            return pesoTotal;

        }

        public void retornaTexto(){
            if(CultureInfo.CurrentCulture.Name == "pt-BR"){
                Console.WriteLine("O desenho {0} tem peso total de {1}.", this.Nome, retornaPeso());
            }else if(CultureInfo.CurrentCulture.Name == "it"){
                Console.WriteLine("Il disegno {0} ha un peso totale di {1}", this.Nome, retornaPeso());
            }else if(CultureInfo.CurrentCulture.Name == "en-US"){
                Console.WriteLine("Drawing {0} has total weight of {1}.", this.Nome, retornaPeso());
            }

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