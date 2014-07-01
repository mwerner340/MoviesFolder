using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesProject1.Models
{
    public class MovieModel
    {
            public int ID { get; set; }
            public string Title { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string Genere { get; set; }
            public decimal Price { get; set; }
        }
        public class MovieDBContext : DbContext
        {
            public DbSet<MoviesProject1.Movies.Movie> Movies { get; set; }

            public System.Data.Entity.DbSet<MoviesProject1.Models.MovieModel> MovieModels { get; set; }

        }
    }


   