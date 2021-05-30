using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.NetBD02
{
    public partial class TesteBD : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTestar_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand();


            try
            {
                cmd.Connection = Conexao.Connection;

                lblResultado.CssClass = "text text-success";
                lblResultado.Text = "Ok... Conectado com Sucesso";

            }
            catch (Exception ex)
            {
                lblResultado.CssClass = "text text-danger";
                lblResultado.Text = "Atenção: " + ex.Message;
            }
            finally
            {
                Conexao.Desconectar();
            }

        }
    }
}