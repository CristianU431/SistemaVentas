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
    /// Descripción breve de wsTiendas
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTiendas : System.Web.Services.WebService
    {

        [WebMethod(Description = "Listar Tiendas")]
        public DataSet Listar()
        {
            TiendasBL tiendas = new TiendasBL();
            return tiendas.Listar();
        }

        [WebMethod(Description = "Agregar Tiendas")]
        public string[] Agregar(string Stor_id, string Stor_name, string Stor_address, string City, string State, string Zip)
        {
            TiendasBL tiendasBL = new TiendasBL();
            Tiendas tiendas = new Tiendas();
            tiendas.Stor_id = Stor_id;
            tiendas.Stor_name = Stor_name;
            tiendas.Stor_address = Stor_address;
            tiendas.City = City;
            tiendas.State = State;
            tiendas.Zip = Zip;
            string[] valores = new string[2];
            valores[0] = tiendasBL.Agregar(tiendas).ToString();
            valores[1] = tiendasBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Actualizar Tiendas")]
        public string[] Actualizar(string Stor_id, string Stor_name, string Stor_address, string City, string State, string Zip)
        {
            TiendasBL tiendasBL = new TiendasBL();
            Tiendas tiendas = new Tiendas();
            tiendas.Stor_id = Stor_id;
            tiendas.Stor_name = Stor_name;
            tiendas.Stor_address = Stor_address;
            tiendas.City = City;
            tiendas.State = State;
            tiendas.Zip = Zip;
            string[] valores = new string[2];
            valores[0] = tiendasBL.Actualizar(tiendas).ToString();
            valores[1] = tiendasBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Eliminar Tiendas")]
        public string[] Eliminar(string Stor_id)
        {
            TiendasBL tiendasBL = new TiendasBL();
            string[] valores = new string[2];
            valores[0] = tiendasBL.Eliminar(Stor_id).ToString();
            valores[1] = tiendasBL.Mensaje;
            return valores;
        }

        [WebMethod(Description = "Buscar Tiendas")]
        public DataSet Buscar(string texto, string criterio)
        {
            TiendasBL tiendas = new TiendasBL();
            return tiendas.Buscar(texto, criterio);
        }

    }
}
