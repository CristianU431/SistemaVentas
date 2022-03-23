using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class TrabajosInicio : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTrabajos.wsTrabajosSoapClient servicio = new srTrabajos.wsTrabajosSoapClient();

        //Metodo para listar Region
        private void Listar()
        {
            gvTrabajos.DataSource = servicio.Listar().Tables[0];
            gvTrabajos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}