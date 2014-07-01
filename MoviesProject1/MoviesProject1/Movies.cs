using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesProject1
{
    public class Movies
    {
        public class Movie
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string Genere { get; set; }
            public decimal Price { get; set; }
        }
        public class MovieDBContext : DbContext
        {
            public DbSet<Movie> Movies { get; set; }

        }
    }
}