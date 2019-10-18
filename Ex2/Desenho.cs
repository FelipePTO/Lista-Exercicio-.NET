
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


        public string retornaMaisPesado(){
            
            int maisPesado = 0;
            string maisPesadoNome = "";

            if(Filhos != null){
                foreach(var i in Filhos){
                    int pesofilho = retornaPesodoFilho(i.Filhos);
                        pesofilho += i.Peso;
                    if(pesofilho > maisPesado){
                        maisPesado=pesofilho;
                        maisPesadoNome=i.Nome;
                    }
                    
                }
            }

            if(maisPesadoNome != ""){
                return maisPesadoNome;
            }else{
                return "Não tem filhos";
            }
        }

    }

}