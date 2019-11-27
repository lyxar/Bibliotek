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

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User DeleteUser(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
            return user;
        }

        public User GetBorrowedBooks(string rfid)
        {
            return _context.Users.Include(user => user.Books).Where(user => user.RFID == rfid).FirstOrDefault();            
        }

        public User GetUserRfid(string rfid)
        {
            return _context.Users.Where(user => user.RFID == rfid).SingleOrDefault();
        }
    }
}
