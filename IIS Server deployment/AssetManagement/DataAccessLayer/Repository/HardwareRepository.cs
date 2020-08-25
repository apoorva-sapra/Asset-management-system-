using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using AssetManagement.Data;
using AssetManagement.Models;

namespace AssetManagement.Repository
{

    public class HardwareRepository : IAssetRepository<Hardware>
    {
        private readonly AssetContext context;

        public HardwareRepository(AssetContext context)
        {
            this.context = context;
        }
        public bool AddAsset(Hardware hardware)
        {
            context.Hardwares.Add(hardware);
            context.SaveChanges();
            return true;    
        }
      
        public List<Hardware> GetAllAssets()
        {
               return context.Set<Hardware>().AsEnumerable()?.ToList();
        }
        public Hardware GetAsset(int id)
        {
            return context.Hardwares.Find(id);
        }
        public Hardware UpdateAsset(Hardware hardwarechange)
        {
            var hardware= context.Hardwares.Update(hardwarechange);
            hardware.State= Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return hardwarechange;
        }
          public Hardware DeleteAsset(Hardware hardware)
        {
            context.Hardwares.Remove(hardware);
            context.SaveChanges();
            return hardware;
        }
    }
}