using System.Net.Http;
using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AssetManagement.Data;
using System.Net;
using AssetManagement.Service;

namespace AssetManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HardwareController : ControllerBase
    {
       
        private readonly  IAsset<Hardware> _hardwareService;
       public HardwareController(IAsset<Hardware> hardware)
        {
            _hardwareService = hardware;
        }
        

        [HttpGet]
        public List<Hardware> GetHardwares()
        {
            return _hardwareService.GetAllAssets();
        }
        [HttpGet("{id}")]
        public ActionResult<Hardware> GetHardware(int id)
        {
            Hardware hardware = _hardwareService.GetAsset(id);
            if(hardware!=null)
                return hardware;
            return BadRequest();
        }

        [HttpPost]
        public HttpResponseMessage AddHardware(Hardware hardware)
        {
            try
                {
               _hardwareService.Add(hardware);
                HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.Created);
                return response;
                }
            catch (Exception)
                {
                        HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.InternalServerError);
                        return response;
                }
           
        }
         [HttpPut]
        
        public HttpResponseMessage UpdateHardware(Hardware hardware)
        {
            try
            {
                if(_hardwareService.Update(hardware)!=null)
                    {
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                    }
                else{
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
                    }
                        
            }
            catch (Exception){
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.InternalServerError);
                    return response;
            }
           
        }
        [HttpDelete("{id}")]
    
           public HttpResponseMessage DeleteHardware(int id)
           { 
                try
                    {
                        
                    _hardwareService.Delete(id);
                    HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.OK);
                    return response;      
                    }
            catch (Exception)
                    {
                            HttpResponseMessage response=new HttpResponseMessage(HttpStatusCode.NotFound);
                    return response;  
                    }
              
           }
    }
}
