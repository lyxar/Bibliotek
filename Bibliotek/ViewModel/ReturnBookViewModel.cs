using Bibliotek.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class ReturnBookViewModel : BaseViewModel
    {
        private IBookDataService _bookService;
        private string _barcode;
        private string _result;
        public string Barcode
        {
            get { return _barcode; }
            set { _barcode = value; OnPropertyChanged("Barcode"); }
        }
        public string Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged("Result"); }
        }

        public ReturnBookViewModel(IBookDataService bookDataService)
        {
            _bookService = bookDataService;
            LoadCommands();
        }


        #region COMMANDS
        public ICommand ReturnBookCommand { get; private set; }
        private void LoadCommands()
        {
            ReturnBookCommand = new RelayCommand(ReturnBookMethod);
        }

        private void ReturnBookMethod()
        {
            var book = _bookService.ReturnBook(Barcode);
            Barcode = string.Empty;
            if (book != null)
                Result = book.Title + " has been returned";
            else
                Result = "The book could not be found";
        }

        #endregion
    }
}
