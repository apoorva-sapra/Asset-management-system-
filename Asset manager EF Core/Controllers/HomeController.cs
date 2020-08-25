using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetManagement.Models;
using AssetManagement.ViewModel;

namespace AssetManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IHardwareRepository _hardwareRepository;
        private readonly ISoftwareRepository _softwareRepository;
        public HomeController(IBookRepository bookRepository,IHardwareRepository hardwareRepository,ISoftwareRepository softwareRepository)
        {
            _bookRepository = bookRepository;
            _hardwareRepository = hardwareRepository;
            _softwareRepository=softwareRepository;
        }

        private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult All()
        {
            AllViewModel model = new AllViewModel();
            model.books = _bookRepository.AllBook();
            model.hardwares=_hardwareRepository.AllHardware();
            model.softwares=_softwareRepository.AllSoftware();
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
