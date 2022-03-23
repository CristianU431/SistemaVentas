using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class TrabajosBuscar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTrabajos.wsTrabajosSoapClient servicio = new srTrabajos.wsTrabajosSoapClient();

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Buscar un Trabajo a la tabla Trabajo
            gvTrabajos.DataSource = servicio.Buscar(txtTexto.Text, txtCriterio.Text).Tables[0];
            gvTrabajos.DataBind(); ;
        }
    }
}