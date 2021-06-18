using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class DiagnosticoCitum
    {
        public DiagnosticoCitum()
        {
            HistorialClinicos = new HashSet<HistorialClinico>();
        }

        public int IdDiagnostico { get; set; }
        public string Descripcion { get; set; }
        public int IdCita { get; set; }

        public virtual Citum IdCitaNavigation { get; set; }
        public virtual ICollection<HistorialClinico> HistorialClinicos { get; set; }
    }
}
