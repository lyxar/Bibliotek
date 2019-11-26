using Bibliotek.Services;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Bibliotek.ViewModel
{
    public class BorrowedBooksViewModel : BaseViewModel
    {
        private IBookDataService _bookService;
        public ObservableCollection<Book> Books { get; set; }
        public BorrowedBooksViewModel(IBookDataService bookDataService)
        {
            _bookService = bookDataService;
            LoadData();
        }

        private void LoadData()
        {
            Books = _bookService.GetBorrowedBooks();
        }
    }
}
