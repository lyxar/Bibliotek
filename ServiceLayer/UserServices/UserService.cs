using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;
using DataLayer.Repsositories;

namespace ServiceLayer.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }
        public User GetBorrowedBooks(string rfid)
        {
            return _repository.GetBorrowedBooks(rfid);
        }
    }
}
