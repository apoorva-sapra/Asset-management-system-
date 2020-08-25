
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConsumeWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Controllers
{
    public class HomeController : Controller
    {

        //  private readonly UserManager<IdentityUser> userManager;
        // private readonly SignInManager<IdentityUser> signInManager;
        // public HomeController(UserManager<IdentityUser> userManager,
        //     SignInManager<IdentityUser> signInManager)
        // {
        //     this.userManager = userManager;
        //     this.signInManager = signInManager;
        // }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //  public IActionResult All()
        // {
        //     return View();
        // }


    }
}
