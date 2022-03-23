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
    public class TiendasBL : Interface.ITiendas
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

        public bool Actualizar(Tiendas tiendas)
        {
            DataRow fila = datos.TraerDataRow("spActualizarTiendas", tiendas.Stor_id, tiendas.Stor_name, tiendas.Stor_address, tiendas.City, tiendas.State, tiendas.Zip);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Tiendas tiendas)
        {
            DataRow fila = datos.TraerDataRow("spAgregarTiendas", tiendas.Stor_id, tiendas.Stor_name, tiendas.Stor_address, tiendas.City, tiendas.State, tiendas.Zip);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTiendas", texto, criterio);
        }

        public bool Eliminar(string stor_id)
        {
            DataRow fila = datos.TraerDataRow("spEliminarTiendas  ", stor_id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTiendas");
        }

    }
}
