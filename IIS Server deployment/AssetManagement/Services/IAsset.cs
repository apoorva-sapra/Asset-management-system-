using System.Collections.Generic;

namespace AssetManagement.Service
{
    public interface IAsset<T>
    {
        T GetAsset(int id);
        List<T> GetAllAssets();
        bool Add(T asset);
        T Update(T assetChange);
        T Delete(int assetId);       
    }
}
