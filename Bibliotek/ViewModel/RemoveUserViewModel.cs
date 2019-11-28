using Bibliotek.Services;
using GalaSoft.MvvmLight.Command;
using ServiceLayer.UserServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Bibliotek.ViewModel
{
    public class RemoveUserViewModel : BaseViewModel
    {
        private IUserService _userService;
        private IDialogService _dialogService;
        private string _rfid;
        private string _result;
        public string RFID
        {
            get { return _rfid; }
            set { _rfid = value; OnPropertyChanged("RFID"); }
        }
        public string Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged("Result"); }
        }

        public RemoveUserViewModel(IUserService userService, IDialogService dialogService)
        {
            _userService = userService;
            _dialogService = dialogService;
            LoadCommands();
        }


        #region COMMANDS
        public ICommand RemoveUserCommand { get; private set; }
        private void LoadCommands()
        {
            RemoveUserCommand = new RelayCommand(RemoveUserMethod);
        }

        private void RemoveUserMethod()
        {
            var user = _userService.DeleteUserRfid(RFID);
            RFID = string.Empty;
            if (user != null)
            { 
                Result = $"{user.FirstName} {user.LastName} has been removed";
                _dialogService.CloseRemoveUserDialog();
            }
            else
                Result = "The User could not be found";
        }
        #endregion
    }
}
