using Bibliotek.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class BorrowBookViewModel : BaseViewModel
    {
        private IBookDataService _bookDataService;
        private string _rfid;
        private string _barcode;
        private string _result;
        public string Rfid
        {
            get { return _rfid; }
            set { _rfid = value; OnPropertyChanged("Rfid"); }
        }        
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
        public BorrowBookViewModel(IBookDataService bookDataService)
        {
            _bookDataService = bookDataService;
            LoadCommands();
        }

        #region COMMANDS
        private void LoadCommands()
        {
            BorrowBookCommand = new RelayCommand(BorrowBookMethod);
        }

        public ICommand BorrowBookCommand { get; set; }

        private void BorrowBookMethod()
        {
            var book = _bookDataService.BorrowBook(Rfid, Barcode);
            if (book != null)
            {
                Barcode = string.Empty;
                Rfid = string.Empty;
                Result = $"{book.Title} is now borrowed";
            }
            else
                Result = "The book or the user could not be found";
            
        }
        #endregion
    }
}
