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
    public class HardwareController : Controller
    {
        [HttpGet]
        public IActionResult AddHardware()
        {
           return View();
        }
        public IActionResult DelHardware()
        {
            return View();
        }
           public IActionResult SearchHardware()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddHardware(Hardware hardware){
                TryUpdateModelAsync(hardware);
                if(ModelState.IsValid)
                {
                    Asset.HardwareList.Add(hardware)   ;
                    
                    return RedirectToAction("Index",Asset.HardwareList);
                }
                else 
                return View();
        } 
         [HttpPost]
        public IActionResult SearchHardware(string id)
        {
            TryUpdateModelAsync(id);
            if(ModelState.IsValid)
                {
                foreach(Hardware hardware in Asset.HardwareList)
                {
                        if(hardware.id==id)
                        {
                            return RedirectToAction("Index",Asset.HardwareList);
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
        public IActionResult DelHardware(string id)
        {
            TryUpdateModelAsync(id);
            if(ModelState.IsValid)
                {
                foreach(Hardware hardware in Asset.HardwareList)
                {
                        if(hardware.id==id)
                        {
                            Asset.HardwareList.Remove(hardware);
                            return RedirectToAction("Index",Asset.HardwareList);
                        }
                }       
            }
        return View();
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