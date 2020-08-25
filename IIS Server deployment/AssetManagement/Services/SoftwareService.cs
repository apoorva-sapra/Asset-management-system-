using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using AssetManagement.Models;
using AssetManagement.Repository;

namespace AssetManagement.Service
{
    public class SoftwareService : AssetService<Software>
    {
        public SoftwareService(IAssetRepository<Software> repository) : base(repository)
        {
           
        }

    }

}