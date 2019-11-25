using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bibliotek.Services
{
    public interface IBookDataService
    {
        Book GetBookById(int id);
    }
}
