using Bibliotek.Services;
using DataLayer.Entities;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.ViewModel
{    
    public class MainViewModel : BaseViewModel
    {
        private IBookDataService _bookservice;

        public MainViewModel(IBookDataService bookDataService)
        {
            _bookservice = bookDataService;
            LoadData();
        }

        private void LoadData()
        {
        }
    }
}
