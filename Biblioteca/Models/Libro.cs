using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string titulo { get; set; }
        public DateTime fechaLanza{get;set;}
        public int AutorId { get; set; }
        public int CategoriaId { get; set; }
        public int EditorialId { get; set; }
        public int IdiomaId { get; set; }
        public int paginas { get; set; }
        public string descripcion { get; set; }

        public virtual Autor Autor { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Editorial Editorial { get; set; }
        public virtual Idioma Idioma { get; set; }
    }
}