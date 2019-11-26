using DataLayer.Contexts;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataLayer.Repsositories
{
    public class UserRepository : IUserRepository
    {
        private readonly LibraryContext _context;
        public UserRepository(LibraryContext context)
        {
            _context = context;
        }

        public User GetBorrowedBooks(string rfid)
        {
            return _context.Users.Include(user => user.Books).Where(user => user.RFID == rfid).FirstOrDefault();            
        }
    }
}
