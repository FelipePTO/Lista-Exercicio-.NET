using System;
using DesenhoModel;
using pardedesenhoModel;
using System.Globalization;		
using System.Collections.Generic;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            PardeDesenho desenhoA = new PardeDesenho();
            PardeDesenho desenhoB = new PardeDesenho();
            PardeDesenho desenhoC = new PardeDesenho();
            PardeDesenho desenhoD = new PardeDesenho();
            PardeDesenho desenhoE = new PardeDesenho();
            PardeDesenho desenhoF = new PardeDesenho();
            PardeDesenho desenhoG = new PardeDesenho();
            PardeDesenho desenhoH = new PardeDesenho();
            
            desenhoA.Peso=1;
            desenhoA.Nome="Desenho A";
            desenhoA.Id=1;

            desenhoB.Peso=2;
            desenhoB.Nome="Desenho B";
            desenhoD.Id=2;

            desenhoC.Peso=3;
            desenhoC.Nome="Desenho C";
            desenhoC.Id=3;

            desenhoD.Peso=2;
            desenhoD.Nome="Desenho D";
            desenhoD.Id=4;

            desenhoE.Peso=4;
            desenhoE.Nome="Desenho E";
            desenhoE.Id=5;

            desenhoF.Peso=1;
            desenhoF.Nome="Desenho F";
            desenhoF.Id=6;

            desenhoG.Peso=6;
            desenhoG.Nome="Desenho G";
            desenhoG.Id=7;

            desenhoH.Peso=1;
            desenhoH.Nome="Desenho H";
            desenhoH.Id=8;


            
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

            //CultureInfo currentCulture = new CultureInfo("es-ES", false);
            
        }
    }
}
