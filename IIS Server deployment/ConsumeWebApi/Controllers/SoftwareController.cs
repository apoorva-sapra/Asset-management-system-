
using System.Data.Common;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ConsumeWebApi.Models;
using System.Net.Http;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace ConsumeWebApi.Controllers
{
   [Authorize (Roles = "Admin , User")] 
    public class SoftwareController : Controller
    {
        [HttpGet]
        [Authorize (Roles = "Admin ")] 
         public ActionResult AddSoftware()
            {
                return View();
            }
      
    [AllowAnonymous]
        public async Task<ActionResult> Index()  
        {  
            string Baseurl = "http://localhost:8001/"; 
            IEnumerable<Software> SoftwareInfo = null;  
              
            using (var client = new HttpClient())  
            {  
                client.BaseAddress = new Uri(Baseurl);  
                client.DefaultRequestHeaders.Clear();  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

                HttpResponseMessage response = await client.GetAsync("software");  
                if (response.IsSuccessStatusCode)  
                {   
                    var softwareResponse = response.Content.ReadAsStringAsync().Result;    
                    SoftwareInfo = JsonConvert.DeserializeObject<IEnumerable<Software>>(softwareResponse);  
                }  
                return View(SoftwareInfo);  
            }  
        }  
        public static List<Software> SoftwareList = new List<Software>();

        
         [Authorize (Roles = "Admin ")] 
         [HttpPost]
            public ActionResult AddSoftware(Software software)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8001/software");
                    var postTask = client.PostAsJsonAsync<Software>("software", software);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View(software);
            }
    
      [Authorize (Roles = "Admin ")] 
      public async Task<IActionResult> UpdateSoftware(int id)
            {
                Software software = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8001/software/");
                   
                    var responseTask = await client.GetAsync(id.ToString());
               
                    if (responseTask.IsSuccessStatusCode)
                    {
                        var readTask = responseTask.Content.ReadAsAsync<Software>();
                        readTask.Wait();

                        software = readTask.Result;
                       
                    }
                }

                return View(software);
            }
    [HttpPost]
    [Authorize (Roles = "Admin ")] 
    public async Task<ActionResult> UpdateSoftware(Software software)
    {
        
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:8001/");


            var putTask = await client.PutAsJsonAsync<Software>("software", software);
            
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
        }
        return View(software);
    }
    
    [Authorize (Roles = "Admin ")] 
    public ActionResult Delete(int id)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:8001/");

           
            var deleteTask = client.DeleteAsync("software/" + id.ToString());
            deleteTask.Wait();

            var result = deleteTask.Result;
            if (result.IsSuccessStatusCode)
            {

                return RedirectToAction("Index");
            }
        }

        return RedirectToAction("Index");
    }

}
}




       