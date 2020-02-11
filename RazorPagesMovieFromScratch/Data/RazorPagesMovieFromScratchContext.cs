using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieFromScratch.Models;

namespace RazorPagesMovieFromScratch.Data
{
    public class RazorPagesMovieFromScratchContext : DbContext
    {
        public RazorPagesMovieFromScratchContext (DbContextOptions<RazorPagesMovieFromScratchContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovieFromScratch.Models.Movie> Movie { get; set; }
    }
}
