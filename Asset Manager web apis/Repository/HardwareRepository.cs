using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using AssetManagement.Data;

namespace AssetManagement.Models
{

    public class HardwareRepository : IHardwareRepository
    {
        private readonly AssetContext context;

        public HardwareRepository(AssetContext context)
        {
            this.context = context;
        }
        public List<Hardware> AllHardware()
        {
            return context.Hardwares.AsEnumerable().ToList();
        }
        public Hardware Add(Hardware hardware)
        {
            context.Hardwares.Add(hardware);
            context.SaveChanges();
            return hardware;
        }

          public Hardware Delete(int Id)
        {
            Hardware hardware = context.Hardwares.Find(Id);
            if (hardware != null)
            {
                context.Hardwares.Remove(hardware);
                context.SaveChanges();
            }
            return hardware;
        }

        public Hardware GetHardware(int Id)
        {
            return context.Hardwares.Find(Id);
        }
        public bool Update(int id,Hardware hardwareChanges)
        {
            if(id==hardwareChanges.id)
            {
            context.Hardwares.Update(hardwareChanges);
            context.SaveChanges();
            return true;
            }
            return false;
        }
    }
}