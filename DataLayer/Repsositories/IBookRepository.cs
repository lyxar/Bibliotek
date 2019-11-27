using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLayer.Repsositories
{
    public interface IBookRepository
    {
        void AddBook(Book book);
        void BorrowBook(string rfid, string barcode);
        Book ReturnBook(string barcode);
        Book GetABookById(int id);
        Book RemoveBook(string barcode);
        ObservableCollection<Book> GetAllBorrowedBooks();
        ObservableCollection<Book> GetBooks();
    }
}
