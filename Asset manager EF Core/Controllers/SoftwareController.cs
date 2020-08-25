using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetManagement.Models;
using AssetManagement.Data;
using AssetManagement.ViewModel;

namespace AssetManagement.Controllers
{
    public class SoftwareController : Controller
    {
        private readonly AssetContext _context;
         private readonly ISoftwareRepository _softwareRepository;
        public SQLSoftwareRepository dbSoftware;
        public SoftwareController(AssetContext context,ISoftwareRepository softwareRepository)
        {
                 _context= context;
                 dbSoftware = new SQLSoftwareRepository(_context);
                 _softwareRepository=softwareRepository;
        }
        [HttpGet]
        public IActionResult AddSoftware()
        {
           return View();
        }
         public IActionResult DelSoftware()
        {
            return View();
        }
           public IActionResult SearchSoftware()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult AddSoftware(Software software)
        {
                TryUpdateModelAsync(software);
                if(ModelState.IsValid)
                {
                dbSoftware.Add(software);
                return RedirectToAction("Index",dbSoftware);
                }
                else 
                return View();

        } 

        public IActionResult Index ()
        {
            AllViewModel model = new AllViewModel();
            model.softwares = _softwareRepository.AllSoftware();
            return View(model);
        }
        [HttpPost]
        public IActionResult SearchSoftware(string id)
        {
            
            if(ModelState.IsValid)
                {
                foreach(Software software in Asset.SoftwareList)
                {
                        if(software.id==id)
                        {
                            return RedirectToAction("Index",Asset.SoftwareList);
                        }
                        else
                        {
                           return RedirectToAction("NFound");
                        }
                }       
            }
           return RedirectToAction("NFound");
        }
        

         [HttpPost]
        public IActionResult DelSoftware(string id)
        {
            if(ModelState.IsValid)
                {
                           var software= dbSoftware.GetSoftware(id);
                            dbSoftware.Delete(software.id);
                            return RedirectToAction("Index",dbSoftware);
                }
            return RedirectToAction("NFound");
            
        }
        
         public IActionResult NFound()
        {
            return View();
        }
    }
}