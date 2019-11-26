using Bibliotek.Services;
using DataLayer.Entities;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class AddBookViewModel : BaseViewModel
    {
        private IBookDataService _bookservice;
        
        public Book Book { get; set; }

        public AddBookViewModel(IBookDataService bookDataService)
        {
            _bookservice = bookDataService;
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
            _bookservice.AddBook(Book);
        }
        #endregion

    }
}
