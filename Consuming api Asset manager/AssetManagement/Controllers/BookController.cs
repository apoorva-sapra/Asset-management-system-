using System.Net.Http;
using System;
using System.Collections.Generic;
using AssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AssetManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
       
        private readonly IBookRepository _bookRepository;
     
        public BookController(IBookRepository bookRepository)
        {
                 _bookRepository = bookRepository;
        }


        [HttpGet]
        public IEnumerable<Book> GetBook()
        {
            return _bookRepository.AllBook();
        }
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            Book book = _bookRepository.GetBook(id);
            if(book!=null)
            return book;
            return BadRequest();
        }
        

        [HttpPost]
        public HttpResponseMessage AddBook(Book book)
        {
             Console.WriteLine("I reached inside api in add function");
            try
                {
               _bookRepository.Add(book);
                HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.Created);
                return response;
                }
            catch (Exception)
            {
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.InternalServerError);
                    return response;
            }
           
        }
         [HttpPut]
        //   [Route("{id}")]
        public HttpResponseMessage UpdateBook(Book book)
        {
            Console.WriteLine("inside update api");
            try
            {
                       if( _bookRepository.Update(book.id,book))
                       {
                        // return new HttpResponseMessage(HttpStatusCode.Created);
                        HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.OK);
                        return response;
                       }
                       else
                       {
                            HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.NotModified);
                            return response;
                       }
                        
            }
            catch (Exception){
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
            }
           
        }
        [HttpDelete("{id}")]
        
           public HttpResponseMessage DeleteBook(int id)
           { 
                try
                    {
                    _bookRepository.Delete(id);
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.OK);
                    return response;      
                    }
            catch (Exception)
                    {
                            HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.NotModified);
                            return response;
                    }
              
           }
    }
}
