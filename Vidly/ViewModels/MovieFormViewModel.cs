using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        [Required]
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime? DateOFRelease { get; set; }


        [Required]
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public short? NumberInStock { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Genre Type")]
        public int? GenreTypeId { get; set; }

        public IEnumerable<GenreType> GenreTypes { get; set; }
        public string Title    
        {	
            get	
            {	
                if (Id != 0)	
                {	
                    return "Edit Movie";	
                }	
                else	
                {	
                    return "New Movie";	
                }	

            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            DateOFRelease = movie.DateOFRelease;
            DateAdded = movie.DateAdded;
            NumberInStock = movie.NumberInStock;
            GenreTypeId = movie.GenreTypeId;

        }
    }
}