using System;
using DesenhoModel;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
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

            
            Desenho[] filhosE = new Desenho[1];
            filhosE[0] = desenhoH;
            
            Desenho[] filhosC = new Desenho[1];
            filhosC[0] = desenhoG;
            
            Desenho[] filhosB = new Desenho[3];
            filhosB[0] = desenhoD;
            filhosB[1] = desenhoE;
            filhosB[2] = desenhoF;
            
            Desenho[] filhosA = new Desenho[2];
            filhosA[0] = desenhoB;
            filhosA[1] = desenhoC;

            
            desenhoE.Filhos = filhosE;
            desenhoC.Filhos = filhosC;
            desenhoB.Filhos = filhosB;
            desenhoA.Filhos = filhosA;

            Console.WriteLine(desenhoA.retornaPeso());
            Console.WriteLine(desenhoB.retornaPeso());
            Console.WriteLine(desenhoC.retornaPeso());
            Console.WriteLine(desenhoD.retornaPeso());
            Console.WriteLine(desenhoE.retornaPeso());
            Console.WriteLine(desenhoF.retornaPeso());
            Console.WriteLine(desenhoG.retornaPeso());
            Console.WriteLine(desenhoH.retornaPeso());
            
        }
    }
}
