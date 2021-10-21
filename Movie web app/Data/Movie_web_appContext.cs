using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Movie_web_app.Models;

namespace Movie_web_app.Data
{
    public class Movie_web_appContext : DbContext
    {
        public Movie_web_appContext (DbContextOptions<Movie_web_appContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
