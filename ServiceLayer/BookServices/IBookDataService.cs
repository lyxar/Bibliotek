using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.Services
{
    public interface IBookDataService
    {
        void AddBook(Book book);
        Book GetBookById(int id);
        Book RemoveBook(string barcode);
    }
}
