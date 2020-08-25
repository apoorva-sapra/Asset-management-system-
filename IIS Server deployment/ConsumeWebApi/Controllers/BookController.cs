using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using ConsumeWebApi.Models;
using System.Net.Http;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace ConsumeWebApi.Controllers
{
    public class BookController : Controller
    {
        string Baseurl = "http://localhost:8001/";
        public static List<Book> BookList = new List<Book>();
        [HttpGet]
        [Authorize(Roles = "Admin ")]
        public ActionResult AddBook()
        {
            return View();
        }



        public async Task<ActionResult> Index()
        {

            IEnumerable<Book> BookInfo = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync("book");
                if (response.IsSuccessStatusCode)
                {
                    var bookResponse = response.Content.ReadAsStringAsync().Result;
                    BookInfo = JsonConvert.DeserializeObject<IEnumerable<Book>>(bookResponse);
                }
                return View(BookInfo);
            }
        }



        [HttpPost]
        [Authorize(Roles = "Admin ")]
        public ActionResult AddBook(Book book)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8001/book/");
                var postTask = client.PostAsJsonAsync<Book>("book", book);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(book);
        }

        [Authorize(Roles = "Admin ")]
        public async Task<IActionResult> UpdateBook(int id)
        {
            Book book = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:8001/book/");

                var responseTask = await client.GetAsync(id.ToString());

                if (responseTask.IsSuccessStatusCode)
                {
                    var readTask = responseTask.Content.ReadAsAsync<Book>();
                    readTask.Wait();

                    book = readTask.Result;

                }
            }

            return View(book);
        }
        [HttpPost]
        [Authorize(Roles = "Admin ")]
        public async Task<ActionResult> UpdateBook(int id,Book book)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                var putTask = await client.PutAsJsonAsync<Book>("book/"+id.ToString(), book);

                if (putTask.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(book);
        }

        [Authorize(Roles = "Admin ")]
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                var deleteTask = client.DeleteAsync("book/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }

    }
}




