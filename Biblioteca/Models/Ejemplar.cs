using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Ejemplar
    {
        public int EjemplarId { get; set; }

        public int numeroEjemplar { get; set; }

        [Display(Name="Estado")]
        public int EstadoId { get; set; }

        [Display(Name = "Libro")]
        public int LibroId { get; set; }

        public virtual Libro Libro { get; set; }
        public virtual Estado Estado { get; set; }

        public virtual ICollection<Alquiler> Alquileres { get; set; }

    }
}