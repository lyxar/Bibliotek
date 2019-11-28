using Bibliotek.Services;
using DataLayer.Entities;
using GalaSoft.MvvmLight.Command;
using ServiceLayer.UserServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class AddUserViewModel : BaseViewModel
    {
        private IUserService _userService;
        private IDialogService _dialogService;

        public User User { get; set; }

        public AddUserViewModel(IUserService userService, IDialogService dialogService)
        {
            _userService = userService;
            _dialogService = dialogService;
            User = new User();
            LoadCommands();
        }

        #region COMMANDS
        public ICommand AddUserCommand { get; private set; }

        private void LoadCommands()
        {
            AddUserCommand = new RelayCommand(AddUserMethod);
        }

        private void AddUserMethod()
        {
            _userService.AddUser(User);
            _dialogService.CloseAddUserDialog();
        }
        #endregion

    }
}
