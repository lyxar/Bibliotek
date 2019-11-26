using Bibliotek.Services;
using Bibliotek.ViewModel;
using DataLayer.Contexts;
using DataLayer.Repsositories;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<IBookDataService, BookDataService>();
            SimpleIoc.Default.Register<IBookRepository, BookRepository>();
            SimpleIoc.Default.Register<LibraryContext>();

            SimpleIoc.Default.Register<MainViewModel>(true);
            SimpleIoc.Default.Register<RemoveBookViewModel>(true);
            SimpleIoc.Default.Register<AddBookViewModel>(true);
            SimpleIoc.Default.Register<BorrowedBooksViewModel>(true);
            SimpleIoc.Default.Register<BorrowBookViewModel>(true);
        }

        public MainViewModel MainViewModel
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }

        public RemoveBookViewModel RemoveBookViewModel
        {
            get { return SimpleIoc.Default.GetInstance<RemoveBookViewModel>(); }
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
    }
}
