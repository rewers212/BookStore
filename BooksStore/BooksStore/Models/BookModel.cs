using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooksStore.Models
{
    public class BookModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public List<GenreModel> Genres { get; set; }
        public string Description { get; set; }
        [Required]
        public string Rating { get; set; }

    }
}