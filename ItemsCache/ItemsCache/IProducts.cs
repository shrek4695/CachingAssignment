using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsCache
{
   public interface IProducts
    {
        int Id { get; set; }
        String Name { get; set; }
        int Price { get; set; }
        String Category { get; set; }
    }
}
