using DataLayer.Entities;
using DataLayer.Repsositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Bibliotek.Services
{
    public class BookDataService : IBookDataService
    {
        private readonly IBookRepository _repository;
        public BookDataService(IBookRepository repository)
        {
            _repository = repository;
        }

        public void AddBook(Book book)
        {
            _repository.AddBook(book);
        }

        public void BorrowBook(string rfid, string barcode)
        {
            _repository.BorrowBook(rfid, barcode);
        }

        public Book GetBookById(int id)
        {
            return _repository.GetABookById(id);
        }

        public ObservableCollection<Book> GetBorrowedBooks()
        {
            return _repository.GetAllBorrowedBooks();
        }

        public Book RemoveBook(string barcode)
        {
            return _repository.RemoveBook(barcode);
        }
    }
}
