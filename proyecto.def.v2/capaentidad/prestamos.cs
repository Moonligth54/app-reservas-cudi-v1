using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capaentidad
{
    public class prestamos
    {
        public int id_prestamo { get; set; }
        public int id_persona { get; set; }
        public int id_recurso { get; set; }
        public int id_usuario { get; set; }
        public string fecha_prestamo { get; set; }
        public string fecha_devolucion { get; set; }
        public string observaciones { get; set; }
    }
}