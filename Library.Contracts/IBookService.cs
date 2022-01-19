using Library.DataContracts;
using System;

namespace Library.Contracts
{
    public interface IBookService
    {
        void Create(CreateBookDto createBookDto);
        BookDto GetById(int id);

    }
}
