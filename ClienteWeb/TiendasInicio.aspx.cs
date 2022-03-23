using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class TiendasInicio : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTiendas.wsTiendasSoapClient servicio = new srTiendas.wsTiendasSoapClient();

        //Metodo para listar Region
        private void Listar()
        {
            gvTiendas.DataSource = servicio.Listar().Tables[0];
            gvTiendas.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo debe cargar la primera vez
            if (!Page.IsPostBack)
                Listar();
        }
    }
}