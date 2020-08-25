using System.Linq;
using System.Net.Http;
using System;
using System.Collections.Generic;
using AssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using AssetManagement.Service;

namespace AssetManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IAsset<Book> _bookService;

        public BookController(IAsset<Book> book)
        {
            _bookService = book;
        }
        
        [HttpGet]
        public List<Book> GetBook()
        {
            Console.WriteLine("in getbook of book controller");
            return _bookService.GetAllAssets();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            Book book = _bookService.GetAsset(id);
            if (book != null)
                return book;
            return BadRequest();
        }


        [HttpPost]
        public HttpResponseMessage AddBook(Book book)
        {
            try
            {
                _bookService.Add(book);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }

        }
        [HttpPut]
          [Route("{id}")]
        public HttpResponseMessage UpdateBook(Book book)
        {
            try
            {
                if (_bookService.Update(book) != null)
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
                }

            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                return response;
            }

        }

        [HttpDelete("{id}")]

        public HttpResponseMessage DeleteBook(int id)
        {
            try
            {
                _bookService.Delete(id);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                return response;
            }

        }
    }
}
