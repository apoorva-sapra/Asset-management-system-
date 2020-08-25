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
    public class SoftwareController : Controller
    {
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
        public IActionResult AddSoftware(Software software){
                TryUpdateModelAsync(software);
                if(ModelState.IsValid)
                {
                Asset.SoftwareList.Add(software);
                return RedirectToAction("Index",Asset.SoftwareList);
                }
                else 
                return View();

        } 

        public IActionResult Index()
        {
            return View();
        } 
        [HttpPost]
        public IActionResult SearchSoftware(string id)
        {
            TryUpdateModelAsync(id);
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
            TryUpdateModelAsync(id);
            if(ModelState.IsValid)
                {
                foreach(Software software in Asset.SoftwareList)
                {
                        if(software.id==id)
                        {
                            Asset.SoftwareList.Remove(software);
                            return RedirectToAction("Index",Asset.SoftwareList);
                        }
                }       
            }
        return View();
        }
         public IActionResult NFound()
        {
            return View();
        }
    }
}