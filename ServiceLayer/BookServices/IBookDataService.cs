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
        void BorrowBook(string rfid, string barcode);
        Book GetBookById(int id);
        Book RemoveBook(string barcode);
        ObservableCollection<Book> GetBorrowedBooks();
    }
}
