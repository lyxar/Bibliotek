using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLayer.Repsositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserRfid(string rfid);
        User DeleteUser(User user);
        User GetBorrowedBooks(string rfid);
    }
}
