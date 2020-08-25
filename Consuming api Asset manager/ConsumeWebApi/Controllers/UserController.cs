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

        // public UserController(UserManager<IdentityUser> userManager,
        //     SignInManager<IdentityUser> signInManager)
        // {
        //     this.userManager = userManager;
        //     this.signInManager = signInManager;
        // }
        
       
        // [Route("User/CreateRequest")]
     public IActionResult CreateRequest(string userId, int assetId, string assetType)
        {
             
                    var request=new Request();
                    
                    request.userId=userId;
                    request.assetId=assetId;
                    request.assetType=assetType;
                    request.requestStatus="Unassigned";

            
                 _requestRepository.Add(request);
               return RedirectToAction("CheckStatus",new {userid=userId});
        }
          [HttpGet]
       
        public IActionResult CheckStatus(string userid)
        {
            IQueryable<Request> requests = context.Requests.AsQueryable();
            List<Request> list = new List<Request>();
            bool userFound = false;
            foreach(var request in requests)
            {
                if(request.userId==userid)
                {
                    list.Add(request);
                    userFound = true;
                }
            }
            if(userFound== true)
            {
                return View(list);
            }
            else if(userFound == false)
            {
                ViewBag.Message= "No request has been sent by you";
            }
            return View();
        }
    }
}