using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Biblioteca.DAL
{
    public class BibliotecaContext: DbContext
    {
        public BibliotecaContext() : base("Biblioteca")
        { }

        public DbSet<Idioma> Idiomas { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Categoria>Categorias { get; set; }
        public DbSet<Pais>Paises{ get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Lector> Lectores { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Alquiler> Alquileres{ get; set; }


    }
}