using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetBD02
{
	public partial class Inserir1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

			MySqlCommand cmd = new MySqlCommand();

			try
            {
				cmd.Connection = Conexao.Connection;
				cmd.CommandText = @"insert into cliente
									(cli_nome, cli_logradouro, cli_numero, cli_complemento, cli_bairro, cli_cidade, cli_uf, cli_sexo)
							  values(@nome, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @sexo)";


				cmd.Parameters.AddWithValue("nome", txtNome.Text);
				cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
				cmd.Parameters.AddWithValue("numero", txtNumero.Text);
				cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
				cmd.Parameters.AddWithValue("bairro", txtBairro.Text);
				cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
				cmd.Parameters.AddWithValue("uf", txtUf.Text);
				cmd.Parameters.AddWithValue("sexo", ddlSexo.Text);


				Conexao.Conectar();

				cmd.ExecuteNonQuery();
				Response.Redirect("Listar.aspx");
		
                //lblResultado.Text = "Inserido com sucesso ";

            }

            catch (Exception ex)
            {
				lblResultado.CssClass = "text text-danger";
				lblResultado.Text = "Falha: " + ex.Message;
            }
			finally
            {
				Conexao.Desconectar();
            }

        }
    }
}