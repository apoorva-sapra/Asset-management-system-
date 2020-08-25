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
    public class HardwareController : Controller
    {
         private readonly AssetContext _context;
         private readonly IHardwareRepository _hardwareRepository;
        public SQLHardwareRepository dbHardware;
        public HardwareController(AssetContext context,IHardwareRepository hardwareRepository)
        {
                 _context= context;
                 dbHardware = new SQLHardwareRepository(_context);
                 _hardwareRepository = hardwareRepository;

        }
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
           
            if(ModelState.IsValid)
                {
                foreach(Hardware hardware in Asset.HardwareList)
                {
                        if(hardware.id==id)
                        {
                            Asset.HardwareList.Remove(hardware);
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
    public IActionResult Index ()
        {
            AllViewModel model = new AllViewModel();
            model.hardwares = _hardwareRepository.AllHardware();
            return View(model);
        }
         public IActionResult NFound()
        {
            return View();
        }
    }
}