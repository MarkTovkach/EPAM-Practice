using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Abstract
{
    public  interface IDiscountService : IService<Discount>
    {
        decimal Calculate(ShopingCart cart);
    }
}
