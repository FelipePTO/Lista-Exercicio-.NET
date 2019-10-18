using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Inicialmente para consumir o SOAP cria o projeto .NET Framework, eu escolhi criar um console application
    Então Cria uma referência a um serviço e adiciona o soap em questão
    Logo após chama a refência criada no Main da minha aplicação e cria o objeto AtendeClienteClient

    Após chama o método busca contrato passando os parâmetros dados.

    o Try Catch trata qualquer tipo de erro que possa vir acontecer na chamada da aplicação

 */
namespace Ex1011
{

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var correios = new CorreiosSoap.AtendeClienteClient();
                var resultado = correios.buscaContrato("123", 1, "teste", "123456");

                Console.WriteLine(resultado);

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
