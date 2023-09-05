using RantlhagoSM_Assign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RantlhagoSM_Assign1.Data
{
    public interface IBookRepository
    {
        IQueryable<Book> GetAllBooks();
        void AddBook(Book book);
        Book GetBookById();
    }
}
