using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NetBD02
{
    public class Conexao
    {

        #region Parametro da Conexao

        private static string Server = "localhost";
        private static string Database = "web_cliente";
        private static string User = "root";
        private static string Password = "0000";
        private static string connectionStrign = $@"Server={Server};Database={Database};
                                                     Uid={User};Pwd={Password};SslMode=none;
                                                     Charset=utf8;";

        #endregion


        // Trazer a biblioteca do MySql Connector

        public static MySqlConnection Connection = new MySqlConnection(connectionStrign);



        #region Metodo Conectar
        public static void Conectar()
        {
            if (Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection.Open();
            }
        }
        #endregion

        #region Metodo Desconectar

        public static void Desconectar()
        {
            if (Connection.State == System.Data.ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        #endregion

    }
}