using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWeb
{
    public partial class DescuentosDatos : System.Web.UI.Page
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

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            // Agregar una Descuento a la tabla Descuento
            string[] msj = servicio.Agregar(txtTipoDescuento.Text, txtIdTienda.Text, txtTamMin.Text, txtTamMax.Text, txtDescuento.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            // eliminar una Descuento a la tabla Descuento
            string[] msj = servicio.Eliminar(txtTipoDescuento.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            // Actualizar una Descuento a la tabla Descuento
            string[] msj = servicio.Actualizar(txtTipoDescuento.Text, txtIdTienda.Text, txtTamMin.Text, txtTamMax.Text, txtDescuento.Text);
            Response.Write("<script>alert('" + msj[0] + " : " + msj[1] + "'); </script>");
            Listar();
        }
    }
}