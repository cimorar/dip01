using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieFromScratch.Data;
using RazorPagesMovieFromScratch.Models;

namespace RazorPagesMovieFromScratch
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieFromScratch.Data.RazorPagesMovieFromScratchContext _context;

        public IndexModel(RazorPagesMovieFromScratch.Data.RazorPagesMovieFromScratchContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
