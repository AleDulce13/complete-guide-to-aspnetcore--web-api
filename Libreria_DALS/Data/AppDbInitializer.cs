using Microsoft.Extensions.DependencyInjection;
using Libreria_DALS.Data.Model;
using Microsoft.AspNetCore.Builder;
using System.Linq;
using System;

namespace Libreria_DALS.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a la BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Books()
                    {
                        Titulo = "1 Book Title",
                        Descripcion = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genero = "Biography",
                        Autor = "1st Author ",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,

                    },
                    new Books()
                    {
                        Titulo = "2 Book Title",
                        Descripcion = "2st Book Description",
                        IsRead = true,
                        Genero = "Biography",
                        Autor = "2st Author ",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    }); 
                    context.SaveChanges();
                }
            }
        }
    }
}

