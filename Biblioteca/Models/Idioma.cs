using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Idioma
    {
        [Display(Name = "Idioma Id")]
        public int IdiomaId { get; set; }

        [Display(Name = "Idioma")]
        public string idioma { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }

    }
}