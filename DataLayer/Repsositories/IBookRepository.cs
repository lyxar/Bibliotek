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
        Book GetABookById(int id);
        Book RemoveBook(string barcode);
        ObservableCollection<Book> GetBooks();
    }
}
