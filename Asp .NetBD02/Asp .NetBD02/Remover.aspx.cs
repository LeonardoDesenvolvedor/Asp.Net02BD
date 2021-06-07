using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetBD02
{
    public partial class remover1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (CapturaID())
            {
                DadosConsulta();
            }
        }

        private bool CapturaID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }

        private void DadosConsulta()
        {
            int idcliente = ObterIDcliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from cliente
                                    where cli_id = @id";

                cmd.Parameters.AddWithValue("@id", idcliente);

                Conexao.Conectar();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtID.Text = reader["cli_id"].ToString();
                    txtNome.Text = reader["cli_nome"].ToString();
                    txtLogradouro.Text = reader["cli_logradouro"].ToString();
                    txtNumero.Text = reader["cli_numero"].ToString();
                    txtComplemento.Text = reader["cli_complemento"].ToString();
                    txtBairro.Text = reader["cli_bairro"].ToString();
                    txtCidade.Text = reader["cli_cidade"].ToString();
                    ddlSexo.Text = reader["cli_sexo"].ToString();
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

        private int ObterIDcliente()
        {
            var id = 0;
            var idURL = Request.QueryString["id"];
            if (!int.TryParse(idURL, out id))
            {
                throw new Exception("ID Inválido");
            }
            if (id <= 0)
            {
                throw new Exception("ID Invialido");
            }
            return id;

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            int idcliente = ObterIDcliente();
            {

                try
                {

                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao.Connection;
                    cmd.CommandText = @"delete from cliente
                                    where cli_id = @id";

                    cmd.Parameters.AddWithValue("@id", idcliente);

                    Conexao.Conectar();
                    cmd.ExecuteNonQuery();

                    Response.Redirect("Listar.aspx");
                }
                catch(Exception ex)
                {
                    throw;
                }
                finally
                {
                    Conexao.Desconectar();
                }
            }




        }

        protected void btnVoltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inserir.aspx");
        }
    }
}



















