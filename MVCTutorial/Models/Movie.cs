using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;

namespace MVCTutorial.Models
   {
       public class Movie
       {
           public int Id { get; set; }
           public string Title { get; set; }
           [Display(Name = "Release Date")]
           [DataType(DataType.Date)]
           [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
           public DateTime ReleaseDate { get; set; }
           public string Genre { get; set; }
           public decimal Price { get; set; }

           public string Description { get; set; }

           public string Description2 { get; set; }
           public string Description5 { get; set; }
    }
   
       public class MovieDbContext : DbContext
       {
           public DbSet<Movie> Movies { get; set; }
       }
   }