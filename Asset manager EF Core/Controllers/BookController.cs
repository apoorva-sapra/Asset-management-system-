using Microsoft.AspNetCore.Mvc;
using AssetManagement.Models;
using AssetManagement.ViewModel;

namespace AssetManagement.Controllers
{
    public class BookController : Controller
    {
       
  
        private readonly IBookRepository _bookRepository;
        
        public BookController(IBookRepository bookRepository)
        {
                
                
                 _bookRepository = bookRepository;
        }

       

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
                db.Add(book);
                return RedirectToAction("Index",db);
                }
                else 
                return View();

        } 
        [HttpPost]
        public IActionResult DelBook(string id)
        {
          
            if(ModelState.IsValid)
                {
                           var book= db.GetBook(id);
                            db.Delete(book.id);
                            return RedirectToAction("Index",db);
                }
            return RedirectToAction("NFound");
        }
         [HttpPost]
        public IActionResult SearchBook(string id)
        {      
            if(ModelState.IsValid)
                {
                            var book= db.GetBook(id);
                            if(book!=null)
                            {
                            return RedirectToAction("Index");
                            }                          
                }    
                return RedirectToAction("NFound");   
         }
 
        public IActionResult Index ()
        {
            AllViewModel model = new AllViewModel();
            model.books = _bookRepository.AllBook();
            return View(model);
        }

        public IActionResult NFound()
        {
            return View();
        }
    }
}