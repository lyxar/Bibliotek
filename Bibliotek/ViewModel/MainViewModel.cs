using Bibliotek.Services;
using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.ViewModel
{    
    public class MainViewModel
    {
        private IBookDataService _bookservice;
        private Book book;

        public MainViewModel(IBookDataService bookDataService)
        {
            _bookservice = bookDataService;
            LoadData();
        }

        private void LoadData()
        {
            book = _bookservice.GetBookById(1);
        }
    }
}
