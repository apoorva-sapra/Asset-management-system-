using System.Collections.Generic;
using System.Linq;

namespace AssetManagement.Models{
    public interface IBookRepository
    {
        Book GetBook(string Id);
        List<Book> AllBook();
        Book Add(Book book);
        Book Delete(string Id);
        Book Update(Book bookChanges);
    }
}
