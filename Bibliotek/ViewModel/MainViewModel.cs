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
            LoadCommands();
        }

        #region COMMANDS
        private void LoadCommands()
        {
            ShowAddBookCommand = new RelayCommand(ShowAddBookMethod);
            ShowRemoveBookCommand = new RelayCommand(ShowRemoveBookMethod);
            ShowReturnBookCommand = new RelayCommand(ShowReturnBookMethod);
            ShowBorrowedBooksCommand = new RelayCommand(ShowBorrowedBooksMethod);
            ShowBorrowBookCommand = new RelayCommand(ShowBorrowBookMethod);
            ShowAddUserCommand = new RelayCommand(ShowAddUserMethod);
            ShowRemoveUserCommand = new RelayCommand(ShowRemoveUserMethod);
        }

        public ICommand ShowAddBookCommand { get; set; }
        public ICommand ShowRemoveBookCommand { get; set; }
        public ICommand ShowReturnBookCommand { get; set; }
        public ICommand ShowBorrowedBooksCommand { get; set; }
        public ICommand ShowBorrowBookCommand { get; set; }
        public ICommand ShowAddUserCommand { get; set; }
        public ICommand ShowRemoveUserCommand { get; set; }

        private void ShowAddBookMethod()
        {
            _dialogService.ShowAddDialog();
        }
        private void ShowRemoveBookMethod()
        {
            _dialogService.ShowRemoveDialog();
        }

        private void ShowReturnBookMethod()
        {
            _dialogService.ShowReturnDialog();
        }
        private void ShowBorrowedBooksMethod()
        {
            _dialogService.ShowBorrowedBooksDialog();
        }
        private void ShowBorrowBookMethod()
        {
            _dialogService.ShowBorrowBookDialog();
        }

        private void ShowAddUserMethod()
        {
            _dialogService.ShowAddUserDialog();
        }
        private void ShowRemoveUserMethod()
        {
            _dialogService.ShowRemoveUserDialog();
        }
        #endregion
    }
}
