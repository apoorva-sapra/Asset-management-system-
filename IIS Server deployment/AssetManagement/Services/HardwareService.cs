
using AssetManagement.Models;
using AssetManagement.Repository;

namespace AssetManagement.Service
{
    public class HardwareService : AssetService<Hardware>
    {
      
        public HardwareService(IAssetRepository<Hardware> repository) : base(repository)
        {
           
        }

    }

}