using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsCache
{
    interface IRepository
    {
        List<Products> GetProducts();
    }
}
