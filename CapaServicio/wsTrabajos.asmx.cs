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
    /// Descripción breve de wsTrabajos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTrabajos : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Trabajos")]
        public DataSet Listar()
        {
            TrabajosBL trabajos = new TrabajosBL();
            return trabajos.Listar();
        }

        [WebMethod(Description = "Agregar Trabajos")]
        public string[] Agregar(string Job_desc, string Min_lvl, string Max_lvl)
        {
            TrabajosBL trabajosBL = new TrabajosBL();
            Trabajos trabajos = new Trabajos();
            trabajos.Job_desc = Job_desc;
            trabajos.Min_lvl = Min_lvl;
            trabajos.Max_lvl = Max_lvl;
            string[] valores = new string[2];
            valores[0] = trabajosBL.Agregar(trabajos).ToString();
            valores[1] = trabajosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Trabajos")]
        public string[] Actualizar(string Job_id, string Job_desc, string Min_lvl, string Max_lvl)
        {
            TrabajosBL trabajosBL = new TrabajosBL();
            Trabajos trabajos = new Trabajos();
            trabajos.Job_id = Job_id;
            trabajos.Job_desc = Job_desc;
            trabajos.Min_lvl = Min_lvl;
            trabajos.Max_lvl = Max_lvl;
            string[] valores = new string[2];
            valores[0] = trabajosBL.Actualizar(trabajos).ToString();
            valores[1] = trabajosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Trabajos")]
        public string[] Eliminar(string Job_id)
        {
            TrabajosBL trabajosBL = new TrabajosBL();
            string[] valores = new string[2];
            valores[0] = trabajosBL.Eliminar(Job_id).ToString();
            valores[1] = trabajosBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Trabajos")]
        public DataSet Buscar(string texto, string criterio)
        {
            TrabajosBL trabajos = new TrabajosBL();
            return trabajos.Buscar(texto, criterio);
        }
    }
}
