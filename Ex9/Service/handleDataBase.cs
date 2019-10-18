using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace handle.database{
    public class handledatabase{

        public readonly IConfiguration _IConfiguration;
        handledatabase(IConfiguration IConfiguration){
            _IConfiguration=IConfiguration;
        }

        public void ExecutaFuncao(){
            
            using (SqlConnection conexao = new SqlConnection(
                _IConfiguration.GetConnectionString("banco_teste")))
            {
                dynamic resultado = conexao.Query<dynamic>("PR_LISTAR_DESENHOS", null, commandType: CommandType.StoredProcedure);
            }
        }

    }
}