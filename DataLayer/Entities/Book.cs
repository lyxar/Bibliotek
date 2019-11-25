using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime? BorrowedDate { get; set; }
        public int? UserFk { get; set; }

        public User User { get; set; }
    }
}
