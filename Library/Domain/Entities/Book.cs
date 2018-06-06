using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

        public Book(string Name, string Author, string Description, string Genre, decimal Price)
        {
            this.Name = Name;
            this.Author = Author;
            this.Description = Description;
            this.Genre = Genre;
        }
    }
}
