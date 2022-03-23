using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Descuentos
    {
        //Atributos de la clase
        private string discounttype;
        private string stor_id;
        private string lowqty;
        private string highqty;
        private string discount;

        //Propiedaddes
        
        public string Discounttype { get => discounttype; set => discounttype = value; }
        public string Stor_id { get => stor_id; set => stor_id = value; }
        public string Lowqty { get => lowqty; set => lowqty = value; }
        public string Highqty { get => highqty; set => highqty = value; }
        public string Discount { get => discount; set => discount = value; }

        


    }
}
