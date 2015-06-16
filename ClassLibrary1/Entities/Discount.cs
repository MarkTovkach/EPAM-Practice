using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;

namespace EShopDomainModel.Entities
{
    public class Discount : IEntity
    {
        public int Id { get; set; }
        public decimal Value { get; set; }

    }
}
