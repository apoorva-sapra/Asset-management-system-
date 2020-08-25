using System;
using System.Linq;
using System.Collections.Generic;
using AssetManagement.Models;
using AssetManagement.Repository;

namespace AssetManagement.Service
{
    public class AssetService<T> : IAsset<T>
    {
       
        private IAssetRepository<T> _repository;
        public AssetService(IAssetRepository<T> repository)
        {
            _repository = repository;
        }

        public List<T> GetAllAssets()
        {
            return _repository.GetAllAssets();
        }
        public T GetAsset(int assetId)
        {
            return _repository.GetAsset(assetId); 
        }

        public bool Add(T asset)
        {
              if(_repository.AddAsset(asset))
              {
               return true;
              }
              return false;
        }
        public T Delete(int assetId)
        {
            var asset= _repository.GetAsset(assetId);
            if(asset!=null)
            {
                return _repository.DeleteAsset(asset);
            }
            return asset;
        }

        public T Update(T asset)
        {
            return _repository.UpdateAsset(asset);
        }
    }
}