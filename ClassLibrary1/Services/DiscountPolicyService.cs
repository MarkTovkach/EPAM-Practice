using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Services
{
    public class DiscountPolicyService : IDiscountPolicyService
    {
        public void MakeDiscount(ShopingCart cart)
        {
            decimal sum = 0;
            foreach (var item in cart.PurchaseItems)
            {
                sum += item.Price;
            }
            if (sum > 500)
            {
                cart.DiscountList.Add(new Discount { Value = sum * (decimal)0.05 });
            }
            if (cart.PurchaseItems.Count > 12)
            {
                cart.DiscountList.Add(new Discount { Value = sum * (decimal)0.08 });
            }
        }
    }
}
