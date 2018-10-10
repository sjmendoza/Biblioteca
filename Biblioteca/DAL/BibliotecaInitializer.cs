using Biblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.DAL
{
    public class BibliotecaInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<BibliotecaContext>
    {
        protected override void Seed(BibliotecaContext context)
        {
            var idiomas = new List<Idioma>
            {
                new Idioma{nombre="Inglés"},
                new Idioma{nombre="Español"},
                new Idioma{nombre="Italiano"},
                new Idioma{nombre="Portugues"}
            };

            idiomas.ForEach(s => context.Idiomas.Add(s));
            context.SaveChanges();

            var categorias = new List<Categoria>
            {
                new Categoria{nombre="Arte"},
                new Categoria{nombre="Biografia"},
                new Categoria{nombre="Ficcion"},
                new Categoria{nombre="Cocina"},
                new Categoria{nombre="Jardineria"},
                new Categoria{nombre="Humor"},
                new Categoria{nombre="Tecnologia"},
                new Categoria{nombre="Infantil"},
                new Categoria{nombre="Psicologia"},
                new Categoria{nombre="Poesia"}
            };

            categorias.ForEach(s => context.Categorias.Add(s));
            context.SaveChanges();

            var paises = new List<Pais>
            {
                new Pais{nombre="El Salvador"},
                new Pais{nombre="Guatemala"},
                new Pais{nombre="Nicaragua"},
                new Pais{nombre="Honduras"},
                new Pais{nombre="Costa Rica"},
                new Pais{nombre="Estados Unidos"},
                new Pais{nombre="Alemania"},
                new Pais{nombre="Inglaterra"},
                new Pais{nombre="Italia"},
                new Pais{nombre="España"}
            };

            paises.ForEach(s => context.Paises.Add(s));
            context.SaveChanges();

            var editoriales = new List<Editorial>
            {
                new Editorial{nombre="Cambridge University Press"},
                new Editorial{nombre="Editorial Alfaguara"},
                new Editorial{nombre="Editorial Alfaguara"},
                new Editorial{nombre="Pearson"},
                new Editorial{nombre="Pearson"},
                new Editorial{nombre="Editorial Santillana"},
                new Editorial{nombre="Editorial Oceano de El Salvador"},
                new Editorial{nombre="McGraw Hill"}
            };

            editoriales.ForEach(s => context.Editoriales.Add(s));
            context.SaveChanges();



        }
    }
}