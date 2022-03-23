using CapaNegocio.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDato;
using CapaEntidad;

namespace CapaNegocio
{
    public class DescuentosBL : Interface.IDescuentos
    {

        //Atributo que devuelve el mensaje del PA
        private string mensaje;

        // Propiedad de solo lectura
        public string Mensaje
        {
            get { return mensaje; }
        }


        //Utilizar los archivos cs de la capa datos
        Datos datos = new DatosSQL();

        public bool Actualizar(Descuentos descuentos)
        {
            DataRow fila = datos.TraerDataRow("spActualizarDescuento ", descuentos.Discounttype, descuentos.Stor_id, descuentos.Lowqty, descuentos.Highqty, descuentos.Discount);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Descuentos descuentos)
        {
            DataRow fila = datos.TraerDataRow("spAgregarDescuentos", descuentos.Discounttype, descuentos.Stor_id, descuentos.Lowqty, descuentos.Highqty, descuentos.Discount);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarDescuento", texto, criterio);
        }

        public bool Eliminar(string discounttype)
        {
            DataRow fila = datos.TraerDataRow("spEliminarDescuento  ", discounttype);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarDescuentos");
        }

    }
}
