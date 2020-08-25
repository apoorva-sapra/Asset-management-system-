using System.Runtime;
using System.Threading.Tasks.Dataflow;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetManagement.Models;

namespace AssetManagement.Controllers
{
    public class BookController : Controller
    {
        [HttpGet]
        public IActionResult AddBook()
        {
           return View();
        }
        public IActionResult DelBook(){
            return View();
        }
        public IActionResult SearchBook()
        {
            return View();
        }
         [HttpPost]
        public IActionResult AddBook(Book book){
                TryUpdateModelAsync(book);
                if(ModelState.IsValid)
                {
                Asset.BookList.Add(book);
                return RedirectToAction("Index",Asset.BookList);
                }
                else 
                return View();

        } 
        [HttpPost]
        public IActionResult DelBook(string id)
        {
            TryUpdateModelAsync(id);
            if(ModelState.IsValid)
                {
                foreach(Book book in Asset.BookList)
                {
                        if(book.id==id)
                        {
                            Asset.BookList.Remove(book);
                            return RedirectToAction("Index",Asset.BookList);
                        }
                }       
            }
            return View();
        }
         [HttpPost]
        public IActionResult SearchBook(string id)
        {
            TryUpdateModelAsync(id);
            if(ModelState.IsValid)
                {
                foreach(Book book in Asset.BookList)
                {
                        if(book.id==id)
                        {
                            return RedirectToAction("Index",Asset.BookList);
                        }
                        else
                        {
                           return RedirectToAction("NFound");
                        }
                }       
            }
           return RedirectToAction("NFound");
        }
        

        public IActionResult Index ()
        {
            return View();
        }

        public IActionResult NFound()
        {
            return View();
        }
    }
}