using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.UserServices
{
    public interface IUserService
    {
        User GetBorrowedBooks(string rfid);
    }
}
