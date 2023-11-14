using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Church_Movies.Models;

namespace Church_Movies.Data
{
    public class Church_MoviesContext : DbContext
    {
        public Church_MoviesContext (DbContextOptions<Church_MoviesContext> options)
            : base(options)
        {
        }

        public DbSet<Church_Movies.Models.Movie> Movie { get; set; } = default!;
    }
}
