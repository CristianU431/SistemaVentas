using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using CapaNegocio;
using CapaEntidad;
using System.Data;

namespace CapaServicio
{
    /// <summary>
    /// Descripción breve de wsDescuentos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsDescuentos : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Descuentos")]
        public DataSet Listar()
        {
            DescuentosBL descuentos = new DescuentosBL();
            return descuentos.Listar();
        }

        [WebMethod(Description = "Agregar Descuentos")]
        public string[] Agregar(string Discounttype, string Stor_id, string Lowqty, string Highqty, string Discount)
        {
            DescuentosBL descuentosBL = new DescuentosBL();
            Descuentos descuentos = new Descuentos();
            descuentos.Discounttype = Discounttype;
            descuentos.Stor_id = Stor_id;
            descuentos.Lowqty = Lowqty;
            descuentos.Highqty = Highqty;
            descuentos.Discount = Discount;
            string[] valores = new string[2];
            valores[0] = descuentosBL.Agregar(descuentos).ToString();
            valores[1] = descuentosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Descuentos")]
        public string[] Actualizar(string Discounttype, string Stor_id, string Lowqty, string Highqty, string Discount)
        {
            DescuentosBL descuentosBL = new DescuentosBL();
            Descuentos descuentos = new Descuentos();
            descuentos.Discounttype = Discounttype;
            descuentos.Stor_id = Stor_id;
            descuentos.Lowqty = Lowqty;
            descuentos.Highqty = Highqty;
            descuentos.Discount = Discount;
            string[] valores = new string[2];
            valores[0] = descuentosBL.Actualizar(descuentos).ToString();
            valores[1] = descuentosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Descuentos")]
        public string[] Eliminar(string discounttype)
        {
            DescuentosBL descuentosBL = new DescuentosBL();
            string[] valores = new string[2];
            valores[0] = descuentosBL.Eliminar(discounttype).ToString();
            valores[1] = descuentosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Trabajos")]
        public DataSet Buscar(string texto, string criterio)
        {
            DescuentosBL descuentos = new DescuentosBL();
            return descuentos.Buscar(texto, criterio);
        }

    }
}
