using EShopDomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;

namespace EShopDomainModel.Entities
{
    public class Items : IEntity
    {
        public int Id { get; set; }
        public string ItemsName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public IList<Category> Category { get; set; }

    }
}
