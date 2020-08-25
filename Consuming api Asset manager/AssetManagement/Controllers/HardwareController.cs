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

namespace AssetManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HardwareController : ControllerBase
    {
       
        private readonly IHardwareRepository _hardwareRepository;
     
        public HardwareController(IHardwareRepository hardwareRepository)
        {
                 _hardwareRepository = hardwareRepository;
        }


        [HttpGet]
        public IEnumerable<Hardware> GetHardwares()
        {
            return _hardwareRepository.AllHardware();
        }
        [HttpGet("{id}")]
        public ActionResult<Hardware> GetHardware(int id)
        {
            Hardware hardware = _hardwareRepository.GetHardware(id);
            if(hardware!=null)
            return hardware;
            return BadRequest();
        }

        [HttpPost]
        public HttpResponseMessage AddHardware(Hardware hardware)
        {
            try
                {
               _hardwareRepository.Add(hardware);
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
                if(_hardwareRepository.Update(hardware.id,hardware))
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
                        
                    _hardwareRepository.Delete(id);
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
