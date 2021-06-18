using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class Especialistum
    {
        public Especialistum()
        {
            AsuntoCita = new HashSet<AsuntoCitum>();
        }

        public int IdEspecialista { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int IdUbicacion { get; set; }

        public virtual Ubicacion IdUbicacionNavigation { get; set; }
        public virtual ICollection<AsuntoCitum> AsuntoCita { get; set; }
    }
}
