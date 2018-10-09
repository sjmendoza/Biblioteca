using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Editorial
    {
        public int EditorialId { get; set; }

        [Display(Name="Editorial")]
        public string editorial { get; set; }

        public virtual ICollection<Libro> Libros { get; set; }
    }
}