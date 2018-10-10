using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Lector
    {
        [Display(Name = "Lector Id")]
        public int LectorId { get; set; }

        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Telefono")]
        public string telefono { get; set; }

        [Display(Name = "Direccion")]
        public string direccion { get; set; }

        [Display(Name = "Codigo Postal")]
        public string codigoPostal { get; set; }

        [Display(Name = "Observaciones")]
        public string observaciones { get; set; }

        public virtual ICollection<Alquiler> Alquileres { get; set; }


    }
}