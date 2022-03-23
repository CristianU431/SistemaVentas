using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface ITrabajos
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Trabajos trabajos);
        bool Eliminar(string job_id);
        bool Actualizar(Trabajos trabajos);
        DataSet Buscar(string texto, string criterio);
    }
}
