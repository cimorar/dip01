using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IList<Movie> Movie { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        
        
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of movies.
            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }
            //Movie = await _context.Movie.ToListAsync();
            Movie = await movies.ToListAsync();


            // Use LINQ to get list of genres.
            IQueryable<string> allGenres = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await allGenres.Distinct().ToListAsync());
        }
    }
}
