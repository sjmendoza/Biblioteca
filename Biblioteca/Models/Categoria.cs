using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Display( Name="Categoría")]
        public string categoria { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }

    }
}