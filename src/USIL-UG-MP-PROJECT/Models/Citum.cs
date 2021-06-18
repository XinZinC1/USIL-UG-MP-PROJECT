using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class Citum
    {
        public Citum()
        {
            BoletaCita = new HashSet<BoletaCitum>();
            DiagnosticoCita = new HashSet<DiagnosticoCitum>();
        }

        public int IdCita { get; set; }
        public DateTime Fecha { get; set; }
        public int IdPaciente { get; set; }
        public int IdAsunto { get; set; }
        public int IdMetodo { get; set; }

        public virtual AsuntoCitum IdAsuntoNavigation { get; set; }
        public virtual MetodoPago IdMetodoNavigation { get; set; }
        public virtual Cliente IdPacienteNavigation { get; set; }
        public virtual ICollection<BoletaCitum> BoletaCita { get; set; }
        public virtual ICollection<DiagnosticoCitum> DiagnosticoCita { get; set; }
    }
}
