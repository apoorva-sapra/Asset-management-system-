using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;

namespace AssetManagement.Models
{

    public class BookRepository : IBookRepository
    {
        private readonly AssetContext context;

        public BookRepository(AssetContext context)
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

        public Book Delete(int Id)
        {
            Book book = context.Books.Find(Id);
            if (book != null)
            {
                context.Books.Remove(book);
                context.SaveChanges();
            }
            return book;
        }

        public Book GetBook(int Id)
        {
            return context.Books.Find(Id);
        }
       public bool Update(int id,Book bookChanges)
        {
            if(id==bookChanges.id)
            {
            context.Books.Update(bookChanges);
            context.SaveChanges();
            return true;
            }
            return false;
        }

    }
}