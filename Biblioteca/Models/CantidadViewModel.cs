using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class CantidadViewModel
    {

        [Display(Name = "Libro")]
        public int id{ get; set; }

        [Display(Name="Autor")]
        public string autor { get; set; }

        [Display(Name = "Titulo")]
        public string titulo { get; set; }

        [Display(Name = "Categoria")]
        public string categoria { get; set; }

        [Display(Name = "Cantidad")]
        public int cantidad{ get; set; }

    }
}