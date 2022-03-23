using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class TiendasDatos : System.Web.UI.Page
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

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una Tienda a la tabla Tienda
            string[] msj = servicio.Agregar(txtId.Text, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtCodPostal.Text );
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una tienda a la tabla Tienda
            string[] msj = servicio.Eliminar(txtId.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una tienda a la tabla tienda
            string[] msj = servicio.Actualizar(txtId.Text, txtNombre.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtCodPostal.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }
    }
}