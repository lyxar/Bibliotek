using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.UserServices
{
    public interface IUserService
    {
        void AddUser(User user);
        User DeleteUserRfid(string rfid);
        User GetBorrowedBooks(string rfid);
    }
}
