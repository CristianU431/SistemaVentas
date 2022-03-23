using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Trabajos
    {
        //Atributos de la clase
        private string job_id;
        private string job_desc;
        private string min_lvl;
        private string max_lvl;

        //Propiedaddes

        public string Job_id { get => job_id; set => job_id = value; }
        public string Job_desc { get => job_desc; set => job_desc = value; }
        public string Min_lvl { get => min_lvl; set => min_lvl = value; }
        public string Max_lvl { get => max_lvl; set => max_lvl = value; }
    }
}
