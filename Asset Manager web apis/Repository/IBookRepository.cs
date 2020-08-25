using System.Collections.Generic;
using System.Linq;

namespace AssetManagement.Models{
    public interface IBookRepository
    {
        Book GetBook(int Id);
        List<Book> AllBook();
        Book Add(Book book);
        Book Delete(int Id);
        bool Update(int id,Book bookChanges);
    }
}
