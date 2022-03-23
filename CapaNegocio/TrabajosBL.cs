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
    public class TrabajosBL : Interface.ITrabajos
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

        public bool Actualizar(Trabajos trabajos)
        {
            DataRow fila = datos.TraerDataRow("spActualizarTrabajo ", trabajos.Job_id, trabajos.Job_desc, trabajos.Min_lvl, trabajos.Max_lvl);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public bool Agregar(Trabajos trabajos)
        {
            DataRow fila = datos.TraerDataRow("spAgregarTrabajos ", trabajos.Job_desc, trabajos.Min_lvl, trabajos.Max_lvl);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarTrabajo ", texto, criterio);
        }

        public bool Eliminar(string job_id)
        {
            DataRow fila = datos.TraerDataRow("spEliminarTrabajo  ", job_id);
            mensaje = fila["Mensaje"].ToString();
            byte codError = Convert.ToByte(fila["CodError"]);
            if (codError == 0) return false;
            else return true;
        }

        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarTrabajos");
        }

    }
}
