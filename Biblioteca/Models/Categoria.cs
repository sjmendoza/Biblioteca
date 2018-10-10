using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Categoria
    {
        [Display(Name = "Categoria Id")]
        public int CategoriaId { get; set; }

        [Display( Name="Categoría")]
        public string nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }

    }
}