using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DataLayer.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string RFID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public ObservableCollection<Book> Books { get; set; }
    }
}
