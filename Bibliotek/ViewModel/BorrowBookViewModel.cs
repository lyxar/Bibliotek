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
        public string Rfid { get; set; }
        public string Barcode { get; set; }
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
            _bookDataService.BorrowBook(Rfid, Barcode);
        }
        #endregion
    }
}
