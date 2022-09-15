using Library.API.Models;
using System;


namespace Library.API.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetAll();
        Book Add(Book newBook);
        Book GetById(Guid Id);
        void Remove(Guid Id);

    }
}
