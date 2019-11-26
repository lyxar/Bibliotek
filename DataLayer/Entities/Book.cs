using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime? BorrowedDate { get; set; }

        public User User { get; set; }
    }
}
