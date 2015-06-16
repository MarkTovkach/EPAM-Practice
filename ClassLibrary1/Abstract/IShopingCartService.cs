using EShopDomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopDomainModel.Abstract
{
    public interface IShopingCartService
    {
        void Add(Items item);
        void Delete(Items item);
        void DeleteAll();
        decimal ComputeTotalValue();
    }
}
