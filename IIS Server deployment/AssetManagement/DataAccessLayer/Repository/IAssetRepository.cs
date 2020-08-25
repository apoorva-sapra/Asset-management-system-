using System.Collections.Generic;
using System.Linq;
namespace AssetManagement.Repository
{
    public interface IAssetRepository<T>
    {
        T GetAsset(int id);
        List<T> GetAllAssets();
        bool AddAsset(T asset);
        T UpdateAsset(T assetChange);
        T DeleteAsset(T asset);       
    }
}