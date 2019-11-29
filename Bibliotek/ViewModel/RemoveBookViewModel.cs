using Bibliotek.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class RemoveBookViewModel : BaseViewModel
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
            set { _result = value;  OnPropertyChanged("Result"); }
        }

        public RemoveBookViewModel(IBookDataService bookDataService)
        {
            _bookService = bookDataService;
            LoadCommands();
        }


        #region COMMANDS
        public ICommand RemoveBookCommand { get; private set; }
        private void LoadCommands()
        {
            RemoveBookCommand = new RelayCommand(RemoveBookMethod);
        }        

        //Tries to remove the book, notifies the user if the book have been removed.
        private void RemoveBookMethod()
        {
            //Returns the book object if the book could be found and removed.
            var book = _bookService.RemoveBook(Barcode);
            Barcode = string.Empty;
            if (book != null)
                Result = book.Title + " has been removed";
            else
                Result = "The Book could not be found";
            
        }
        
        #endregion
    }
}
