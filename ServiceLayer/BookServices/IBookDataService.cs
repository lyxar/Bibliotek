using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Bibliotek.Services
{
    public interface IBookDataService
    {
        void AddBook(Book book);
        Book BorrowBook(string rfid, string barcode);
        Book GetBookById(int id);
        Book RemoveBook(string barcode);
        Book ReturnBook(string barcode);
        ObservableCollection<Book> GetBorrowedBooks();
    }
}
