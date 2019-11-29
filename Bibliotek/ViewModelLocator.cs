using Bibliotek.Services;
using Bibliotek.ViewModel;
using DataLayer.Contexts;
using DataLayer.Repsositories;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using ServiceLayer.UserServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace Bibliotek
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<IBookDataService, BookDataService>();
            SimpleIoc.Default.Register<IBookRepository, BookRepository>();
            SimpleIoc.Default.Register<IUserService, UserService>();
            SimpleIoc.Default.Register<IUserRepository, UserRepository>();
            SimpleIoc.Default.Register<LibraryContext>();

            #region ViewModels Register
            SimpleIoc.Default.Register<MainViewModel>(true);
            SimpleIoc.Default.Register<RemoveBookViewModel>(true);
            SimpleIoc.Default.Register<ReturnBookViewModel>(true);
            SimpleIoc.Default.Register<AddBookViewModel>(true);
            SimpleIoc.Default.Register<BorrowedBooksViewModel>(true);
            SimpleIoc.Default.Register<BorrowBookViewModel>(true);
            SimpleIoc.Default.Register<AddUserViewModel>(true);
            SimpleIoc.Default.Register<RemoveUserViewModel>(true);
            #endregion

            Messenger.Default.Register<NotificationMessage>(this, NotifyUserMethod);
        }

        #region ViewModelProperties
        public MainViewModel MainViewModel
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }

        public RemoveBookViewModel RemoveBookViewModel
        {
            get { return SimpleIoc.Default.GetInstance<RemoveBookViewModel>(); }
        }
        public ReturnBookViewModel ReturnBookViewModel
        {
            get { return SimpleIoc.Default.GetInstance<ReturnBookViewModel>(); }
        }

        public AddBookViewModel AddBookViewModel
        {
            get { return SimpleIoc.Default.GetInstance<AddBookViewModel>(); }
        }

        public BorrowedBooksViewModel BorrowedBooksViewModel
        {
            get { return SimpleIoc.Default.GetInstance<BorrowedBooksViewModel>(); }
        }

        public BorrowBookViewModel BorrowBookViewModel
        {
            get { return SimpleIoc.Default.GetInstance<BorrowBookViewModel>(); }
        }

        public AddUserViewModel AddUserViewModel
        {
            get { return SimpleIoc.Default.GetInstance<AddUserViewModel>(); }
        }

        public RemoveUserViewModel RemoveUserViewModel
        {
            get { return SimpleIoc.Default.GetInstance<RemoveUserViewModel>(); }
        }
        #endregion
        private void NotifyUserMethod(NotificationMessage message)
        {
            MessageBox.Show(message.Notification);
        }
    }
}
