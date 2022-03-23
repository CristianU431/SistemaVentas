using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class DescuentosInicio : System.Web.UI.Page
    {
        //Acceder al servicio web
        srDescuentos.wsDescuentosSoapClient servicio = new srDescuentos.wsDescuentosSoapClient();

        //Metodo para listar Region
        private void Listar()
        {
            gvDescuentos.DataSource = servicio.Listar().Tables[0];
            gvDescuentos.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}