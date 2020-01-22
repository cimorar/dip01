using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieRci.Models;

namespace RazorPagesMovieRci.Data
{
    public class RazorPagesMovieRciContext : DbContext
    {
        public RazorPagesMovieRciContext (DbContextOptions<RazorPagesMovieRciContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieRci.Models.Movie> Movie { get; set; }
    }
}
