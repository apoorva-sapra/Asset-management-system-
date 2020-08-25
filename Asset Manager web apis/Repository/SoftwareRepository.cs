using System.Net.Http;
using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;

namespace AssetManagement.Models
{

    public class SoftwareRepository : ISoftwareRepository
    {
        private readonly AssetContext context;

        public SoftwareRepository(AssetContext context)
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

          public Software Delete(int Id)
        {
            Software software = context.Softwares.Find(Id);
            if (software != null)
            {
                context.Softwares.Remove(software);
                context.SaveChanges();
            }
            return software;
        }

        public Software GetSoftware(int Id)
        {
            return context.Softwares.Find(Id);
        }
        public bool Update(int id,Software softwareChanges)
        {
            if(id==softwareChanges.id)
            {
            context.Softwares.Update(softwareChanges);
            context.SaveChanges();
            return true;
            }
            return false;
        }

    }
}