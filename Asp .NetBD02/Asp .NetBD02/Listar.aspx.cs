using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetBD02
{
    public partial class Listar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarClientes();

        }
        private void CarregarClientes()
        {

            string query = @"SELECT cli_id, cli_nome FROM cliente";
            DataTable dt = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, Conexao.Connection);
                da.Fill(dt);

                rptClientes.DataSource = dt;
                rptClientes.DataBind();

            }
            catch(Exception ex)
            {
                lblMsg.Text = $"Falha:" + ex.Message;

            }
            finally
            {
                Conexao.Desconectar();
            }

        }
    }
}