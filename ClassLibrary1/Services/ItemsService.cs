using EShopDomainModel.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Services
{
   public class ItemsService : IItemsService
   {
        private IRepository<Items> repository;

        public void Add(Items item)
        {
            repository.Create(item);
            if (item == null)
            {
                throw new NullReferenceException();
            }
        }

        public void Delete(Items item)
        {
            repository.Delete(item);
        }

        public Items GetById(int id)
        {
           return  repository.GetById(id);
        }

       public IQueryable<Items> GetAll()
       {
           return repository.GetAll();
       }
   }
}
