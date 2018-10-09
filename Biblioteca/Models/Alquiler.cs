using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Alquiler
    {
        [Display(Name = "Alquier Id")]
        public int AlquilerId { get; set; }

        [Display(Name = "Lector")]
        public int LectorId { get; set; }
        
        [Display(Name ="Libro")]
        public int LibroId { get; set; }

        public DateTime fechaSalida { get; set; }

        [Display(Name = "Fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime fechaEntrada { get; set; }

        public virtual Lector Lector { get; set; }
        public virtual Libro Libro { get; set; }
    }
}