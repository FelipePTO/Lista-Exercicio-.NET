using DesenhoModel;

namespace pardedesenhoModel{
    public class PardeDesenho : Desenho{
        
        public override int retornaPeso(){
            return base.retornaPeso()*2;
        }
    }
}