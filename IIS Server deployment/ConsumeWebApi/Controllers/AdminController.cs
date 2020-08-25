using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ConsumeWebApi.Models;
using AssetManagement;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace ConsumeWebApi.Controllers
{
    [Authorize(Roles="Admin")]  
      public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly ConsumeApiDbContext context;

        public AdminController(ConsumeApiDbContext context, RoleManager<IdentityRole> roleManager,UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.context=context;
        }

        
        [HttpGet]
        [Route("Admin/ListUsers")]
        public IActionResult ListUsers()
        {
            Console.WriteLine("list users adminstrator controller");
            var users = userManager.Users;
            return View(users);
        }

        [HttpGet]
         [Route("Admin/ListRoles")]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
         [HttpPost]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {id} cannot be found";
                return View("NotFound");
            }
            else
            {
            var result = await userManager.DeleteAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("ListUsers");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View("ListUsers");
        }
    }

   
        public IActionResult RequestAction(int requestId,string status)
        {
            Request asset = context.Requests.Find(requestId);

            asset.requestStatus = status;
            context.Requests.Update(asset);
            context.SaveChanges();
            return RedirectToAction("ShowRequests");
        }
 
        [HttpGet]
        public IActionResult ShowRequests()
        {
            return View(context.Requests.ToList());
        }

    
        
    }
}