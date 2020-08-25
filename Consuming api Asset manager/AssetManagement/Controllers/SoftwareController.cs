using System.Net.Http;
using System;
using System.Collections.Generic;
using AssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace AssetManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoftwareController : ControllerBase
    {
       
        private readonly ISoftwareRepository _softwareRepository;
     
        public SoftwareController(ISoftwareRepository softwareRepository)
        {
                 _softwareRepository = softwareRepository;
        }
        [HttpGet("{id}")]
        public ActionResult<Software> GetSoftware(int id)
        {
            Software software = _softwareRepository.GetSoftware(id);
            if(software!=null)
            return software;
            return BadRequest();
        }


        [HttpGet]
        public IEnumerable<Software> ReadHardwares()
        {
            return _softwareRepository.AllSoftware();
        }

        [HttpPost]
        public HttpResponseMessage AddSoftware(Software software)
        {
            try
                {
               _softwareRepository.Add(software);
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
           
        public HttpResponseMessage UpdateSoftware(Software software)
        {
            try
            {
                if(_softwareRepository.Update(software.id,software))
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
  
           public HttpResponseMessage DeleteSoftware(int id)
           { 
                try
                    {
                        
                    _softwareRepository.Delete(id);
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
