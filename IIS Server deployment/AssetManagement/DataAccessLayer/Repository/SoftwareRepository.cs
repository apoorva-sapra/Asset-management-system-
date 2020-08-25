using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;
using AssetManagement.Models;
namespace AssetManagement.Repository
{

    public class SoftwareRepository : IAssetRepository<Software>
    {
        private readonly AssetContext context;

        public SoftwareRepository(AssetContext context)
        {
            this.context = context;
        }
         public bool AddAsset(Software software)
        {
            context.Softwares.Add(software);
            context.SaveChanges();
            return true;
            
        }

        public List<Software> GetAllAssets()
        {
                   return context.Set<Software>().AsEnumerable()?.ToList();
        }
        public Software GetAsset(int id)
        {
            return context.Softwares.Find(id);
        }
        public Software UpdateAsset(Software softwarechange)
        {
            var software= context.Softwares.Update(softwarechange);
            software.State= Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return softwarechange;
        }
                public Software DeleteAsset(Software software)
        {
            context.Softwares.Remove(software);
            context.SaveChanges();
            return software;
        }
    }
}