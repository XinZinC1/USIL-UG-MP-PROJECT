using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class Ubicacion
    {
        public Ubicacion()
        {
            Especialista = new HashSet<Especialistum>();
        }

        [Required(ErrorMessage = "El campo ID Ubicación es obligatorio.")]
        public int IdUbicacion { get; set; }
        [Required(ErrorMessage = "El campo Región es obligatorio.")]
        public string Region { get; set; }
        [Required(ErrorMessage = "El campo Ciudad es obligatorio.")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "El campo Dirección es obligatorio.")]
        public string Direccion { get; set; }

        public virtual ICollection<Especialistum> Especialista { get; set; }
    }
}
