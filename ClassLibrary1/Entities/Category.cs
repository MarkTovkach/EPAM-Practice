using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopDomainModel.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IList<Items> Items { get; set; }

        
    }
}
