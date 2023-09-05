using RantlhagoSM_Assign1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RantlhagoSM_Assign1.Data
{
    public class BookRepository : IBookRepository
    {
        public readonly AppDbContext _appDbContext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddBook(Book book)
        {
            _appDbContext.Add(book);
            _appDbContext.SaveChanges();
        }
        public IQueryable<Book> GetAllBooks()
        {
            return _appDbContext.Books;
        }

        public Book GetBookById()
        {
            return _appDbContext.Books.FirstOrDefault(p => p.BookId == GetAllBooks().Count<Book>());
        }
    }
}
