using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetBD02
{
    public partial class editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                if(CapturaID())
                {
                    DadosConsulta();
                }

            }
        }

        private bool CapturaID()
        {
            return Request.QueryString.AllKeys.Contains("id");
        }



        private void DadosConsulta()
        {
            int IDcliente = ObterIDCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @"select * from cliente
                                    where cli_id = @IDcliente";

              
                cmd.Parameters.AddWithValue("@IDcliente", IDcliente);

                Conexao.Conectar();

                var reader= cmd.ExecuteReader();

                while (reader.Read())
                {

                    txtId.Text = reader["cli_id"].ToString();
                    txtNome.Text = reader["cli_nome"].ToString();
                    txtLogradouro.Text = reader["cli_logradouro"].ToString();
                    txtNumero.Text = reader["cli_numero"].ToString();
                    txtComplemento.Text = reader["cli_complemento"].ToString();
                    txtBairro.Text = reader["cli_bairro"].ToString();
                    txtCidade.Text = reader["cli_cidade"].ToString();
                    txtUf.Text = reader["cli_uf"].ToString();
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

        private int ObterIDCliente()
        {
            int id = 0;
            var idURL = Request.QueryString["id"];
            if(!int.TryParse(idURL, out id))
            {
                throw new Exception("ID Inválido");
            }
            if (id <= 0)
            {
                throw new Exception("ID Inválido");
            }

            return id;

        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand();


            try
            {

                cmd.Connection = Conexao.Connection;
                cmd.CommandText = @" update cliente
                                    set cli_nome        = @nome,
                                        cli_logradouro  = @logradouro,
                                        cli_numero      = @numero,
                                        cli_complemento = @complemento,
                                        cli_bairro      = @bairro,
                                        cli_cidade      = @cidade,
                                        cli_sexo        = @sexo

                                        where cli_id    = @id";

                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@logradouro", txtLogradouro.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@complemento", txtComplemento.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
                cmd.Parameters.AddWithValue("@sexo", ddlSexo.Text);


                Conexao.Conectar();
                cmd.ExecuteNonQuery();
                Response.Redirect("Listar.aspx");


            }
            catch(Exception ex)
            {
                lblResultado.Text = $"Erro: {ex.Message}";
            }
            finally
            {
                Conexao.Desconectar();
            }



        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("listar.aspx");
        }
    }
}