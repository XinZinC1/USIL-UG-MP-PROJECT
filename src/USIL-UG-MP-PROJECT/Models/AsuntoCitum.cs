using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class AsuntoCitum
    {
        public AsuntoCitum()
        {
            Cita = new HashSet<Citum>();
        }

        public int IdAsunto { get; set; }
        public decimal Precio { get; set; }
        public int IdEspecialista { get; set; }

        public virtual Especialistum IdEspecialistaNavigation { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
    }
}
