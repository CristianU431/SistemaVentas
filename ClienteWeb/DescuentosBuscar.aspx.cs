using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class DescuentosBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srDescuentos.wsDescuentosSoapClient servicio = new srDescuentos.wsDescuentosSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar una tienda en la tabla Tienda
            gvDescuentos.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvDescuentos.DataBind();
        }
    }
}