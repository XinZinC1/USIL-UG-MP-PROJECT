using System;
using System.Collections.Generic;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class BoletaCitum
    {
        public int IdBoleta { get; set; }
        public DateTime Fecha { get; set; }
        public int IdCliente { get; set; }
        public int IdCita { get; set; }

        public virtual Citum IdCitaNavigation { get; set; }
        public virtual Cliente IdClienteNavigation { get; set; }
    }
}
