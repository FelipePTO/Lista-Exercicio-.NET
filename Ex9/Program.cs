using System;
using DesenhoModel;
using pardedesenhoModel;
using System.Globalization;		
using System.Collections.Generic;
using funcaoValidacao;
using Microsoft.Extensions.Configuration;
using handle.database;
using Microsoft.Extensions.DependencyInjection;


namespace Ex4
{
    class Program
    {

        static public void imprimeDados(PardeDesenho desenho){
            desenho.retornaTexto();
        }

        static void Main(string[] args)
        {

            IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
            .Build();

            handledatabase db = new handledatabase();

            //Chama a procedure do exercício com o Dapper
            db.ExecutaFuncao();
            

        }
    }
}
