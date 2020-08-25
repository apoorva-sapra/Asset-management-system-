using System.Net.Http;
using System;
using System.Collections.Generic;
using AssetManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using AssetManagement.Service;

namespace AssetManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SoftwareController : ControllerBase
    {

        private readonly IAsset<Software> _softwareService;
        public SoftwareController(IAsset<Software> software)
        {
            _softwareService = software;
        }

        [HttpGet("{id}")]
        public ActionResult<Software> GetSoftware(int id)
        {
            Software software = _softwareService.GetAsset(id);
            if (software != null)
                return software;
            return BadRequest();
        }


        [HttpGet]
        public IEnumerable<Software> ReadSoftwares()
        {
            return _softwareService.GetAllAssets();
        }

        [HttpPost]
        public HttpResponseMessage AddSoftware(Software software)
        {
            try
            {
                _softwareService.Add(software);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }

        }
        [HttpPut]

        public HttpResponseMessage UpdateSoftware(Software software)
        {
            try
            {
                if (_softwareService.Update(software) != null)
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                    return response;
                }
                else
                {
                    HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotModified);
                    return response;
                }

            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }

        }
        [HttpDelete("{id}")]

        public HttpResponseMessage DeleteSoftware(int id)
        {
            try
            {

                _softwareService.Delete(id);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);
                return response;
            }
            catch (Exception)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }

        }
    }
}
