using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;

namespace AssetManagement.Models
{

    public class SQLSoftwareRepository : ISoftwareRepository
    {
        private readonly AssetContext context;

        public SQLSoftwareRepository(AssetContext context)
        {
            this.context = context;
        }
        public List<Software> AllSoftware()
        {
            return context.Softwares.AsEnumerable().ToList();
        }
        public Software Add(Software software)
        {
            context.Softwares.Add(software);
            context.SaveChanges();
            return software;
        }

        public Software Delete(string Id)
        {
            Software software = context.Softwares.Find(Id);
            if(software != null)
            {
                context.Softwares.Remove(software);
                context.SaveChanges();
            }
            return software;
        }

        public Software GetSoftware(string Id)
        {
            return context.Softwares.Find(Id);
        }
        public Software Update(Software softwareChanges)
        {
            var software = context.Softwares.Attach(softwareChanges);
            software.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return softwareChanges;
        }
    }
}