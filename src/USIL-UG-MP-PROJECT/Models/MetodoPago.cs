using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class MetodoPago
    {
        public MetodoPago()
        {
            Cita = new HashSet<Citum>();
        }

        [Required(ErrorMessage = "El campo ID de Método de Pago es obligatorio.")]
        public int IdMetodo { get; set; }
        [Required(ErrorMessage = "El campo Nombre de Empresa es obligatorio.")]
        public string Empresa { get; set; }
        [Required(ErrorMessage = "El campo Descripcion de la Empresa es obligatorio.")]
        public string Descripcion { get; set; }

        public virtual ICollection<Citum> Cita { get; set; }
    }
}
