﻿using Bibliotek.Views;
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
    }
}
