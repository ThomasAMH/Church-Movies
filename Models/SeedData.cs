using Church_Movies.Data;
using Church_Movies.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Church_Movies.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new Church_MoviesContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<Church_MoviesContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Price = 2,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2001-12-14"),
                    Genre = "Drama",
                    Price = 7,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-06-03"),
                    Genre = "Historical Adventure",
                    Price = 3,
                    Rating = "PG"
                },
                new Movie
                {
                    Title = "The RM",
                    ReleaseDate = DateTime.Parse("2003-01-31"),
                    Genre = "Comedy",
                    Price = 1,
                    Rating = "PG"
                }
            );
            context.SaveChanges();
        }
    }
}