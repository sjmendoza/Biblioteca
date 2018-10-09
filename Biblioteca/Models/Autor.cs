using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Autor
    {
        
        public int AutorId { get; set; }

        [Display(Name = "Nombre")]
        public string nombre { get; set; }

        [Display(Name = "Apellido")]
        public string apellido { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaNac { get; set; }

        [Display(Name ="Pais")]
        public int PaisId { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual ICollection<Libro> Libros { get; set; }


    }
}