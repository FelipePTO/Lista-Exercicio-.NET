using DesenhoModel;
using Xunit;

namespace Ex1.Teste {
    public class Teste {

        [Fact]
        public void TextExecicio1()
        {
            Desenho desenhoA = new Desenho();
            Desenho desenhoB = new Desenho();
            Desenho desenhoC = new Desenho();
            Desenho desenhoD = new Desenho();
            Desenho desenhoE = new Desenho();
            Desenho desenhoF = new Desenho();
            Desenho desenhoG = new Desenho();
            Desenho desenhoH = new Desenho();

            desenhoA.Peso=1;
            desenhoB.Peso=2;
            desenhoC.Peso=3;
            desenhoD.Peso=2;
            desenhoE.Peso=4;
            desenhoF.Peso=1;
            desenhoG.Peso=6;
            desenhoH.Peso=1;

            Desenho[] filhosA = new Desenho[1];
            filhosA[0] = desenhoB;
            filhosA[1] = desenhoC;


            Desenho[] filhosB = new Desenho[2];
            filhosB[0] = desenhoD;
            filhosB[1] = desenhoE;
            filhosB[2] = desenhoF;

            Desenho[] filhosC = new Desenho[0];
            filhosC[0] = desenhoG;

            Desenho[] filhosE = new Desenho[0];
            filhosE[0] = desenhoH;

            
            desenhoE.Filhos = filhosE;
            desenhoC.Filhos = filhosC;
            desenhoB.Filhos = filhosB;
            desenhoA.Filhos = filhosA;
                       
            

            Assert.Equal(20, desenhoA.retornaPeso());
            
        }
    }
}