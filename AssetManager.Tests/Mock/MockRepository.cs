using System;
using System.Collections.Generic;
using System.Linq;
using AssetManagement.Models;
using AssetManagement.Repository;
using AssetManagement.Service;

namespace AssetManagement.Tests.Mock
{
    public class MockRepository<T> : IAssetRepository<T> where T : class
    {
        private static int id;
        static MockRepository()
        {
            id = 0;
            Assets = new Dictionary<int, T>();
        }
        public static Dictionary<int, T> Assets { get; set; }
        public bool AddAsset(T asset)
        {
            if (asset == null)
                return false;
            id += 1;
            Assets.Add(id, asset);
            Console.WriteLine(Assets);
            return true;
        }
         public List<T> GetAllAssets()
        {
            return Assets.Values.ToList();
        }

        public T GetAsset(int id)
        {
            if (Assets.ContainsKey(id))
            {
                return Assets[id];
            }
            return null;
        }

        public T DeleteAsset(T asset)
        {
            if (asset == null)
                return null;
            if (!Assets.ContainsValue(asset))
                return null;
            var key = Assets.FirstOrDefault(x => x.Value == asset).Key;
            if (Assets.Remove(key))
            {
                return asset;
            }
            return null;
        }

        public T UpdateAsset(T asset)
        {
            if (asset == null)
                return null;
            if (Assets.ContainsValue(asset))
                return asset;
            return null;
        }

    }
}
