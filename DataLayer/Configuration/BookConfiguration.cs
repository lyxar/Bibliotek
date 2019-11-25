using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Configuration
{
    class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasIndex(b => b.Barcode)
                .IsUnique();

            entity.HasData(
                new Book { Id = 1, Title = "To Kill A Mockingbird", Barcode = "1234", Description = "Lorem ipsum", Author = "Harper Lee" },
                new Book { Id = 2, Title = "Harry Potter", Barcode = "4312", Description = "Lorem ipsum", Author = "J. K. Rowling" }
            );
        }
    }
}
