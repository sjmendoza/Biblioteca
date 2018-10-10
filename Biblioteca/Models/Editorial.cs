using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Editorial
    {
        [Display(Name = "Editorial Id")]
        public int EditorialId { get; set; }

        [Display(Name="Editorial")]
        public string nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}