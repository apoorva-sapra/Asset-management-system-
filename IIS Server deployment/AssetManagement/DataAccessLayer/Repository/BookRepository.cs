using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;
using Microsoft.AspNetCore.Mvc;
using AssetManagement.Controllers;
using AssetManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Repository
{

    public class BookRepository : IAssetRepository<Book>
    {
        private readonly AssetContext context;

        public BookRepository(AssetContext context)
        {
            this.context = context;
        }
        public List<Book> GetAllAssets()
        {
            return context.Set<Book>().AsEnumerable()?.ToList();
        }
        public Book GetAsset(int id)
        {
            return context.Books.Find(id);
        }
        public bool AddAsset(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return true;
        }
        public Book DeleteAsset(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
            return book;
        }

        public Book UpdateAsset(Book bookchange)
        {
            var book = context.Set<Book>().Attach(bookchange);
            book.State =EntityState.Modified;
            context.SaveChanges();
            return bookchange;
        }
    }
}
