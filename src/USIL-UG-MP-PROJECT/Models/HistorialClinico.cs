using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class HistorialClinico
    {
        public int IdHistorial { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int IdDiagnostico { get; set; }

        public virtual DiagnosticoCitum IdDiagnosticoNavigation { get; set; }
    }
}
