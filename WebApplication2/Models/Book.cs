using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Book
    {
        
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        [Key]
        public string ISBN13 { get; set; }

        public Book(string Title, string Author, int PageNumber, string ISBN13)
        {
            this.Title = Title;
            this.Author = Author;
            this.PageNumber = PageNumber;
            this.ISBN13 = ISBN13;
        }

        public Book()
        {

        }
        
    }
}
