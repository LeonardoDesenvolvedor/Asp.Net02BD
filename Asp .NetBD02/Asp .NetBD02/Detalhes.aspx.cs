using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetBD02
{
    public partial class Detalhes : System.Web.UI.Page
    {
        #region Page_Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CapturarID())
            {
                DadosConsulta();
            }
        }
        #endregion

        #region CapituraID
        private bool CapturarID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }
        #endregion


        #region DaodosDaConsulta
        private void DadosConsulta()
        {
            int IDCliente = ObterIDCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from cliente
                                    where cli_id = @IDCliente";

                cmd.Parameters.AddWithValue("@IDCliente", IDCliente);

                Conexao.Conectar();

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {

                    txtID.Text = reader["cli_id"].ToString();
                    txtNome.Text = reader["cli_nome"].ToString();
                    txtLogradouro.Text = reader["cli_logradouro"].ToString();
                    txtNumero.Text = reader["cli_numero"].ToString();
                    txtComplemento.Text = reader["cli_complemento"].ToString();
                    txtBairro.Text = reader["cli_bairro"].ToString();
                    txtCidade.Text = reader["cli_cidade"].ToString();
                    txtUf.Text = reader["cli_uf"].ToString();
                    txtSexo.Text = reader["cli_sexo"].ToString();


                }

            }
            catch (Exception ex)
            {
                throw;
            }

            finally
            {
                Conexao.Desconectar();
            }
        }
        #endregion

        #region ObeterIDCliente
        private int ObterIDCliente()
        {
            int id = 0;
            var idURL = Request.QueryString["id"];

            if(!int.TryParse(idURL, out id))
            {
                throw new Exception("ID Inválido");
            }

            if(id <= 0)
            {
                throw new Exception("ID Inválido");
            }

            return id;
        }

         #endregion
    }
}