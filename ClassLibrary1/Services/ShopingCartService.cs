using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Services
{
    public class ShopingCartService : IShopingCartService
    {
        private ShopingCart cart;
        private Discount discount;
        private IDiscountService discountService;
        public ShopingCartService(ShopingCart cart, Discount discount, IDiscountService discountService)
        {
            this.cart = cart;
            this.discount = discount;
            this.discountService = discountService;
        }
        public void Add(Items item)
        {
            if (item == null)
            {
                throw new ArgumentNullException();
            }
            cart.PurchaseItems.Add(item);
        }

        public void Delete(Items item)
        {
            cart.PurchaseItems.Remove(item);

        }

        public void DeleteAll()
        {
            cart.PurchaseItems.Clear();
        }

        public decimal ComputeTotalValue()
        {
            return discountService.Calculate(cart);
        }

       
    }
}
