using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class devoluciones
    {
        public int id_devolucion { get; set; }
        public int id_prestamo { get; set; }
        public int id_encargado_recepcion { get; set; }
        public DateTime fecha_devolucion { get; set; }
        public string estado_fisico { get; set; }
        public string observaciones { get; set; }
    }
}
