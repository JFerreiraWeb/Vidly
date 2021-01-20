using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.DTOS
{
    public class MovieDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime DateOFRelease { get; set; }

        [Required]
        [Range(1, 20)]
        public short NumberInStock { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        public int GenreTypeId { get; set; }

        public MovieDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}