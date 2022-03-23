using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface ITiendas
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Tiendas tiendas);
        bool Eliminar(string stor_id);
        bool Actualizar(Tiendas tiendas);
        DataSet Buscar(string texto, string criterio);
    }
}
