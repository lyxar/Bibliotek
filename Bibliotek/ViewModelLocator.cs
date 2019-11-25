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
            SimpleIoc.Default.Register<IBookDataService, BookDataService>();
            SimpleIoc.Default.Register<IBookRepository, BookRepository>();
            SimpleIoc.Default.Register<LibraryContext>();

            SimpleIoc.Default.Register<MainViewModel>(true);
        }

        public MainViewModel MainViewmodel
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }
    }
}
