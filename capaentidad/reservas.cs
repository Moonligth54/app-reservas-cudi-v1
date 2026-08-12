using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaentidad
{
    public class reservas
    {
        public int id_reserva { get; set; }
        public int id_solicitante { get; set; }
        public usuarios osolicitante { get; set; } // Objeto del usuario solicitante
        public int id_recurso { get; set; }
        public recursos orecurso { get; set; } // Objeto del recurso reservado
        public string fecha_solicitud { get; set; }
        public string fecha_reserva_inicio { get; set; }
        public string fecha_reserva_fin { get; set; }
        public string estado { get; set; }
        public int? id_encargado_revision { get; set; }
        public usuarios oencargado_revision { get; set; } // Objeto del encargado que revisa
        public string observaciones_encargado { get; set; }
    }
}
