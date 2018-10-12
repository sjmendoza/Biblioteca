using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Estado
    {
        public int EstadoId { get; set; }

        [Display(Name="Estado")]
        public string nombre { get; set; }

        public virtual ICollection<Ejemplar> Ejemplares { get; set; }
    }
}