using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Lector
    {
        public int LectorId { get; set; }


        public string apellido { get; set; }


        public string nombre { get; set; }


        public string telefono { get; set; }


        public string direccion { get; set; }


        public string codigoPostal { get; set; }


        public string observaciones { get; set; }

        public virtual ICollection<Alquiler> Alquileres { get; set; }


    }
}