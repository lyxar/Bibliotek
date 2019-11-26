using Bibliotek.Services;
using DataLayer.Entities;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{    
    public class MainViewModel : BaseViewModel
    {
        private IBookDataService _bookService;
        private IDialogService _dialogService;

        public MainViewModel(IBookDataService bookDataService, IDialogService dialogService)
        {
            _bookService = bookDataService;
            _dialogService = dialogService;
            LoadData();
            LoadCommands();
        }

        private void LoadData()
        {
        }

        #region COMMANDS
        private void LoadCommands()
        {
            ShowAddBookCommand = new RelayCommand(ShowAddBookMethod);
            ShowRemoveBookCommand = new RelayCommand(ShowRemoveBookMethod);
            ShowBorrowedBooksCommand = new RelayCommand(ShowBorrowedBooksMethod);
            ShowBorrowBookCommand = new RelayCommand(ShowBorrowBookMethod);
        }

        public ICommand ShowAddBookCommand { get; set; }
        public ICommand ShowRemoveBookCommand { get; set; }
        public ICommand ShowBorrowedBooksCommand { get; set; }
        public ICommand ShowBorrowBookCommand { get; set; }

        private void ShowAddBookMethod()
        {
            _dialogService.ShowAddDialog();
        }
        private void ShowRemoveBookMethod()
        {
            _dialogService.ShowRemoveDialog();
        }
        private void ShowBorrowedBooksMethod()
        {
            _dialogService.ShowBorrowedBooksDialog();
        }
        private void ShowBorrowBookMethod()
        {
            _dialogService.ShowBorrowBookDialog();
        }
        #endregion
    }
}
