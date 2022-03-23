using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class TiendasBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTiendas.wsTiendasSoapClient servicio = new srTiendas.wsTiendasSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar una tienda a la tabla Tiendas
            gvTiendas.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvTiendas.DataBind();

        }
    }
}