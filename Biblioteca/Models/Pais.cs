using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Pais
    {
        public int PaisId { get; set; }

        [Display(Name="Pais")]
        public string pais { get; set; }

        public virtual ICollection<Autor> Autores { get; set; }
    }
}