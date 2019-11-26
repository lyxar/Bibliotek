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

        private void AddBookMethod()
        {
            _bookService.AddBook(Book);
            Book = null;
            _dialogService.CloseAddDialog();
        }
        #endregion

    }
}
