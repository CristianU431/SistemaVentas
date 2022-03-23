using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class TrabajosModificar : System.Web.UI.Page
    {
        //Acceder al servicio web
        srTrabajos.wsTrabajosSoapClient servicio = new srTrabajos.wsTrabajosSoapClient();

        //Metodo para listar Region
        private void Listar()
        {
            gvTrabajadores.DataSource = servicio.Listar().Tables[0];
            gvTrabajadores.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una escuela a la tabla Escuela
            string[] msj = servicio.Agregar(txtDescripcion.Text, txtmin.Text, txtmax.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una escuela a la tabla Escuela
            string[] msj = servicio.Eliminar(txtId.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una escuela a la tabla Escuela
            string[] msj = servicio.Actualizar(txtId.Text, txtDescripcion.Text, txtmin.Text, txtmax.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }
    }
}