using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Entities
{
    public class ShopingCart : IEntity
    {
        public int Id { get; set; }
        public List<Items> PurchaseItems { get; set; }

        public OrderStatus Status { get; set; }
        public decimal Sum
        {
            get
            {
                decimal sum = 0;
                foreach (var item in PurchaseItems)
                {
                    sum += item.Price;
                }
                return sum;
            }

        }
        public IList<Discount> DiscountList { get; set; }
        public DateTime Date { get; set; }


    }
}
