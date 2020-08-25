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
    public class SoftwareController : ControllerBase
    {
       
        private readonly ISoftwareRepository _softwareRepository;
     
        public SoftwareController(ISoftwareRepository softwareRepository)
        {
                 _softwareRepository = softwareRepository;
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
            [Route("{id}")]
        public HttpResponseMessage UpdateSoftware(int id,Software software)
        {
            try
            {
                if(_softwareRepository.Update(id,software))
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
        [HttpDelete]
        [Route("{id}")]
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
