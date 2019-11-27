using DataLayer.Contexts;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
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

        public void BorrowBook(string rfid, string barcode)
        {
            Book book = _context.Books.Where(book => book.Barcode == barcode).FirstOrDefault();
            book.BorrowedDate = DateTime.Now;
            User user = _context.Users.Where(user => user.RFID == rfid).FirstOrDefault();
            user.Books.Add(book);
            _context.SaveChanges();
        }

        public Book GetABookById(int id)
        {
            return _context.Books.Where(x => x.Id == id).FirstOrDefault();
        }

        public ObservableCollection<Book> GetAllBorrowedBooks()
        {
            var query = _context.Books.Include(book => book.User).Where(book => book.BorrowedDate != null);
            var ObservableBooks = new ObservableCollection<Book>(query);
            return ObservableBooks;
        }

        public ObservableCollection<Book> GetBooks()
        {
            var ObservableBooks = new ObservableCollection<Book>(_context.Books);
            return ObservableBooks;
        }

        public Book RemoveBook(string barcode)
        {
            try
            {
                Book selected = _context.Books.Where(b => b.Barcode == barcode).SingleOrDefault();
                _context.Books.Remove(selected);
                _context.SaveChanges();
                return selected;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Book ReturnBook(string barcode)
        {
            try
            {
                Book selected = _context.Books.Where(book => book.Barcode == barcode).SingleOrDefault();
                selected.BorrowedDate = null;
                selected.User = null;
                _context.SaveChanges();
                return selected;
            }
            catch (Exception)
            {
                return null;
            }
            
        }
    }
}
