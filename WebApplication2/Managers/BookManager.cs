using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Managers
{
    public class BookManager
    {
        public static List<Book> _books = new List<Book>() 
        {
            new Book("book1", "me", 512, "123A"),
            new Book("book2", "you", 520, "123B"),
            new Book("book3", "he", 564, "123C")
        };

        public List<Book> GetAll()
        {
            return new List<Book>(_books);
        } 

    }

}
