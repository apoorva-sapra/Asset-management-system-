using System;
using ConsumeWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;


namespace ConsumeWebApi.Controllers
{
    public class UserController: Controller
    {
        // private readonly UserManager<IdentityUser> userManager;
        // private readonly SignInManager<IdentityUser> signInManager;
        private readonly ConsumeApiDbContext context;
        private readonly IRequest _requestRepository;
     
        public UserController(ConsumeApiDbContext context,IRequest requestRepository)
        {
            this.context = context;
              _requestRepository = requestRepository;
        }

     public IActionResult CreateRequest(string userId, int assetId, string assetType)
        {
            string id=User.Identity.Name;
             Console.WriteLine("id"+id);
                    var request=new Request();
                    
                    request.userId=id;
                    request.assetId=assetId;
                    request.assetType=assetType;
                    request.requestStatus="Unassigned";

            
                 _requestRepository.Add(request);
               return RedirectToAction("CheckStatus",new {userid=userId});
        }
          [HttpGet]
       
        public IActionResult CheckStatus()
        {
            IQueryable<Request> requests = context.Requests.AsQueryable();
            List<Request> requestList = new List<Request>();
            bool userFound = false;
            foreach(var request in requests)
            {
                if(request.userId==User.Identity.Name)
                {
                    requestList.Add(request);
                    userFound = true;
                }
            }
            if(userFound== true)
            {
                return View(requestList);
            }
            else if(userFound == false)
            {
                ViewBag.Message= "No request has been sent by you";
            }
            return View();
        }
    }
}