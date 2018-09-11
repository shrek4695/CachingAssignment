using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Collections;
using System.Data.SqlClient;

namespace ItemsCache
{
    class Cache:ICache
    {
        private const string CacheKey = "availableProducts";
        ObjectCache cache = MemoryCache.Default;
        public IEnumerable GetAvailableProducts()
        {
            

            if (cache.Contains(CacheKey))
                return (IEnumerable)cache.Get(CacheKey);
            else
            {
                IEnumerable availableProducts = this.GetDefaultProducts();
                CacheItemPolicy cacheItemPolicy = new CacheItemPolicy();
                cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(1);
                cache.Add(CacheKey, availableProducts, cacheItemPolicy);
                return availableProducts;
            }
        }
        public List<Products> GetDefaultProducts()
        {
            Database obj = new Database();
            List < Products> products= obj.GetProducts();
            return products;
        }
    }
}
