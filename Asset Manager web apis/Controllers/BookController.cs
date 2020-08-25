using System.Net.Http;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetManagement.Data;
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
        public IEnumerable<Book> ReadBooks()
        {
            return _bookRepository.AllBook();
        }
        [HttpPost]
        public HttpResponseMessage AddBook(Book book)
        {
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
            [Route("{id}")]
        public HttpResponseMessage UpdateBook(int id,Book book)
        {
            try
            {
                       if( _bookRepository.Update(id,book))
                       {
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
        [HttpDelete]
        [Route("{id}")]
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
