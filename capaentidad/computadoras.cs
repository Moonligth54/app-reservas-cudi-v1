using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class computadoras
    {
        public int id_computadora { get; set; }
        public int id_recurso { get; set; }
        public int numero_equipo { get; set; }
        public string tipo { get; set; } // "Notebook", "Netbook", "Isla"
    }
}
