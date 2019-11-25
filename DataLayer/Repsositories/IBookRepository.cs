using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Repsositories
{
    public interface IBookRepository
    {
        Book GetABookById(int id);
    }
}
