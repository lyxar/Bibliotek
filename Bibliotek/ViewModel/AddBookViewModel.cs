using Bibliotek.Services;
using DataLayer.Entities;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class AddBookViewModel : BaseViewModel
    {
        private IBookDataService _bookService;
        private IDialogService _dialogService;
        
        //The book that will be used to bind and later added to the database
        public Book Book { get; set; }

        public AddBookViewModel(IBookDataService bookDataService, IDialogService dialogService)
        {
            _bookService = bookDataService;
            _dialogService = dialogService;
            Book = new Book();
            LoadCommands();
        }

        #region COMMANDS
        public ICommand AddBookCommand { get; private set; }

        private void LoadCommands()
        {
            AddBookCommand = new RelayCommand(AddBookMethod);
        }

        //Method for the command to add a new book to the database
        private void AddBookMethod()
        {
            _bookService.AddBook(Book);
            //Clears the book so it is ready for a new one.
            Book = null;
            //Closes the window
            _dialogService.CloseAddDialog();
        }
        #endregion

    }
}
