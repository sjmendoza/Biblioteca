using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Idioma
    {
        public int IdiomaId { get; set; }

        public string idioma { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }

    }
}