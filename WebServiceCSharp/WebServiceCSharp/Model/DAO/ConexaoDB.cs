using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebServiceCSharp.Model.DAO
{
    public class ConexaoDB
    {
        private static MySqlConnection Conexao;
        private static MySqlCommand Comando;
        private static MySqlDataAdapter Daptador;
        private static DataTable Tabela;

        public void conectar()
        {
            Conexao = new MySqlConnection("server=localhost;port=3306;User Id=root;database=alan; password=root");
            Conexao.Open();
        }
        public void desconectar()
        {
            Conexao.Close();
        }

        public void comandosql(string sql)
        {
            Comando = new MySqlCommand(sql, Conexao);
            Comando.ExecuteNonQuery();
        }
    }
}
