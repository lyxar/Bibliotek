using Bibliotek.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Bibliotek.Services
{
    public class DialogService : IDialogService
    {
        Window AddBookView = null;
        Window RemoveBookView = null;
        Window BorrowedBooksView = null;
        Window BorrowBookView = null;
        Window ReturnBookView = null;
        Window AddUserView = null;
        Window RemoveUserView = null;

        public void ShowAddDialog()
        {
            AddBookView = new AddBookView();
            AddBookView.ShowDialog();
        }

        public void CloseAddDialog()
        {
            if (AddBookView != null)
                AddBookView.Close();
        }

        public void ShowRemoveDialog()
        {
            RemoveBookView = new RemoveBookView();
            RemoveBookView.ShowDialog();
        }
        public void ShowReturnDialog()
        {
            ReturnBookView = new ReturnBookView();
            ReturnBookView.ShowDialog();
        }

        public void ShowBorrowedBooksDialog()
        {
            BorrowedBooksView = new BorrowedBooksView();
            BorrowedBooksView.ShowDialog();
        }

        public void ShowBorrowBookDialog()
        {
            BorrowBookView = new BorrowBookView();
            BorrowBookView.ShowDialog();
        }

        public void ShowAddUserDialog()
        {
            AddUserView = new AddUserView();
            AddUserView.ShowDialog();
        }

        public void CloseAddUserDialog()
        {
            if(AddUserView != null)
                AddUserView.Close();
        }

        public void ShowRemoveUserDialog()
        {
            RemoveUserView = new RemoveUserView();
            RemoveUserView.ShowDialog();
        }

        public void CloseRemoveUserDialog()
        {
            if (RemoveUserView != null)
                RemoveUserView.Close();
        }
    }
}
