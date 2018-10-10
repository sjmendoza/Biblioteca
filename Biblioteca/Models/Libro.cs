using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Libro
    {
        [Display(Name = "Libro Id")]
        public int LibroId { get; set; }

        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Display(Name = "Fecha Lanzamiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaLanza{get;set;}

        [Display(Name = "Autor")]
        public int AutorId { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        [Display(Name = "Editorial")]
        public int EditorialId { get; set; }

        [Display(Name = "Idioma")]
        public int IdiomaId { get; set; }

        [Display(Name = "N° Pag.")]
        public int paginas { get; set; }

        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }

        [Display(Name = "Autor")]
        public virtual Autor Autor { get; set; }

        [Display(Name = "Categoria")]
        public virtual Categoria Categoria { get; set; }
        public virtual Editorial Editorial { get; set; }
        public virtual Idioma Idioma { get; set; }

        public virtual ICollection<Alquiler> Alquileres { get; set; }

    }
}