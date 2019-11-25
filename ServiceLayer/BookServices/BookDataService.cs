using DataLayer.Repsositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.Services
{
    public class BookDataService : IBookDataService
    {
        private readonly IBookRepository _repository;
        public BookDataService(IBookRepository repository)
        {
            _repository = repository;
        }
    }
}
