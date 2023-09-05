using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RantlhagoSM_Assign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RantlhagoSM_Assign1.Data
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book { BookId = 1, BookTitle = "The Eight sister", BookAuthor = "Robert Dugoni", BookISBN = "978-1-64358-214-6", BookIsRead = "true"},
                new Book { BookId = 2, BookTitle = "The Night Fire", BookAuthor = "Michael Connelly", BookISBN = "978-1-4091-8606-9", BookIsRead = "true" },
                new Book { BookId = 3, BookTitle = "Troubled Blood", BookAuthor = "Robert Galbraith", BookISBN = "0316498939", BookIsRead = "true" },
                new Book { BookId = 4, BookTitle = "Winter Garden", BookAuthor = "Kristin Hannah", BookISBN = "978-1-4692-3573-8", BookIsRead = "true" }
                );

                context.SaveChanges();
            }
        }
    }
}
