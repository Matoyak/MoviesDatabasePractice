using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesDatabasePractice.Models {
    public class Movie {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must provide a title!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "You must provide a director!")]
        public string Director { get; set; }

        public string ReleaseYear { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
