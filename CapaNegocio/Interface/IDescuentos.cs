using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using System.Data;

namespace CapaNegocio.Interface
{
    interface IDescuentos
    {
        // Declarar metodos comunes
        DataSet Listar();
        bool Agregar(Descuentos descuentos);
        bool Eliminar(string discounttype);
        bool Actualizar(Descuentos descuentos);
        DataSet Buscar(string texto, string criterio);
    }
}
