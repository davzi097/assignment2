using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using Assignment1;


namespace WebApplication2.Managers
{
    public class BookManager
    {
        public static List<Book> _books = new List<Book>() 
        {
            new Book{Title="book1", Author="me", PageNumber=512, ISBN13="123A" },
            new Book{Title="book2", Author="you", PageNumber=520, ISBN13="123B" },
            new Book{Title="book3", Author="he", PageNumber=564, ISBN13="123C" }
        };

        public List<Book> GetAll()
        {
            return _books;
        } 

    }

}
