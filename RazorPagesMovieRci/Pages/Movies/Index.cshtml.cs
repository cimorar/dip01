using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovieRci.Data;
using RazorPagesMovieRci.Models;

namespace RazorPagesMovieRci
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovieRci.Data.RazorPagesMovieRciContext _context;

        public IndexModel(RazorPagesMovieRci.Data.RazorPagesMovieRciContext context)
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
