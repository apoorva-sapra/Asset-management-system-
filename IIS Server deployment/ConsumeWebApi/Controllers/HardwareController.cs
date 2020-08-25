
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
   
    public class HardwareController : Controller
    {
        [HttpGet]
        [Authorize (Roles = "Admin ")] 
         public ActionResult AddHardware()
            {
                return View();
            }
      
        
            
        public async Task<ActionResult> Index()  
        {  
            string Baseurl = "http://localhost:8001/"; 
            IEnumerable<Hardware> HardwareInfo = null;  
              
            using (var client = new HttpClient())  
            {  
                client.BaseAddress = new Uri(Baseurl);  
                client.DefaultRequestHeaders.Clear();  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));  

                HttpResponseMessage response = await client.GetAsync("hardware");  
                if (response.IsSuccessStatusCode)  
                {   
                    var hardwareResponse = response.Content.ReadAsStringAsync().Result;    
                    HardwareInfo = JsonConvert.DeserializeObject<IEnumerable<Hardware>>(hardwareResponse);  
                }  
                return View(HardwareInfo);  
            }  
        }  
        public static List<Hardware> HardwareList = new List<Hardware>();

         [Authorize (Roles = "Admin ")] 
         [HttpPost]
            public ActionResult AddHardware(Hardware hardware)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8001/hardware");
                    var postTask = client.PostAsJsonAsync<Hardware>("hardware", hardware);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

                return View(hardware);
            }
            
      [Authorize (Roles = "Admin ")] 
      public async Task<IActionResult> UpdateHardware(int id)
            {
                Hardware hardware = null;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8001/hardware/");
                   
                    var responseTask = await client.GetAsync(id.ToString());
                    // responseTask.Wait();

                    // var result = responseTask.Result;
                    if (responseTask.IsSuccessStatusCode)
                    {
                        var readTask = responseTask.Content.ReadAsAsync<Hardware>();
                        readTask.Wait();

                        hardware = readTask.Result;
                       
                    }
                }

                return View(hardware);
            }
    [HttpPost]
    [Authorize (Roles = "Admin ")] 
    public async Task<ActionResult> UpdateHardware(Hardware hardware)
    {
        
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:8001/");


            var putTask = await client.PutAsJsonAsync<Hardware>("hardware", hardware);
            
            if (putTask.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
        }
        return View(hardware);
    }
    [Authorize (Roles = "Admin ")] 
    public ActionResult Delete(int id)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("http://localhost:8001/");

           
            var deleteTask = client.DeleteAsync("hardware/" + id.ToString());
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




       