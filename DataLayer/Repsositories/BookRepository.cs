using DataLayer.Contexts;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DataLayer.Repsositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;
        public BookRepository(LibraryContext context)
        {
            _context = context;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public Book GetABookById(int id)
        {
            return _context.Books.Where(x => x.Id == id).FirstOrDefault();
        }

        public ObservableCollection<Book> GetBooks()
        {
            var ObservableBooks = new ObservableCollection<Book>(_context.Books);
            return ObservableBooks;
        }

        public Book RemoveBook(string barcode)
        {
            Book selected = _context.Books.Where(b => b.Barcode == barcode).SingleOrDefault();
            _context.Books.Remove(selected);
            _context.SaveChanges();
            return selected;
        }
    }
}
