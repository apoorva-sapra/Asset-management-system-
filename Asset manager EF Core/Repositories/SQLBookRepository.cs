using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;

namespace AssetManagement.Models
{

    public class SQLBookRepository : IBookRepository
    {
        private readonly AssetContext context;

        public SQLBookRepository(AssetContext context)
        {
            this.context = context;
        }
        public List<Book> AllBook()
        {
            return context.Books.AsEnumerable().ToList();
        }
        public Book Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return book;
        }

        public Book Delete(string Id)
        {
            Book book = context.Books.Find(Id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
            return book;
        }

        public Book GetBook(string Id)
        {
            return context.Books.Find(Id);
        }
        public Book Update(Book bookChanges)
        {
            var book = context.Books.Attach(bookChanges);
            book.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return bookChanges;
        }
    }
}