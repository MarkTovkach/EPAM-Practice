using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Services
{
    class DiscountService : IDiscountService
    {
        private IRepository<Discount> repository;
        private IDiscountPolicyService discountPolicy;
        public decimal Calculate(ShopingCart cart)
        {
            discountPolicy.MakeDiscount(cart);
            decimal res = 0;
            foreach (var discount in cart.DiscountList)
            {
                res += discount.Value;

            }
            return cart.Sum - res;
        }

        public void Add(Discount item)
        {
            repository.Create(item);
            if (item == null)
            {
                throw new NullReferenceException();
            }
            
        }

        public void Delete(Discount item)
        {
            repository.Delete(item);
        }

        public Discount GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
