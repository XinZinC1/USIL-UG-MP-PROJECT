using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            BoletaCita = new HashSet<BoletaCitum>();
            Cita = new HashSet<Citum>();
        }

        public int IdCliente { get; set; }
        public int Dni { get; set; }
        public int Celular { get; set; }
        public string Email { get; set; }

        public virtual ICollection<BoletaCitum> BoletaCita { get; set; }
        public virtual ICollection<Citum> Cita { get; set; }
    }
}
