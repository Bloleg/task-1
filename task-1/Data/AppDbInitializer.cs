using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using task_1.Data.Models;

namespace task_1.Data
{
    public class AppDbInitializer
    {

        public static void Seed(IApplicationBuilder applicationbuilder) {

            using (var servisScope = applicationbuilder.ApplicationServices.CreateScope()) {
                var context = servisScope.ServiceProvider.GetService<AppDbContext>();


                if (context.Books.Any() )
                {
                    return;   // DB has been seeded
                }
                var books = new Book[]
                    {
                        new Book {Title="book-1",Auther="Ol-1", Discription="book-test1-1", IsRead = false, DateRead=DateTime.Parse("2022-01-01")},
                        new Book {Title="book-2",Auther="Ol-2", Discription="book-test1-2", IsRead = false, DateRead=DateTime.Parse("2022-01-01")},
                        new Book {Title="book-3",Auther="Ol-3", Discription="book-test1-3", IsRead = false, DateRead=DateTime.Parse("2022-01-01")}
                };

                foreach (Book s in books)
                {
                    context.Books.Add(s);
                }
                context.SaveChanges();
            }
        }
    }
}
