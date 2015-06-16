using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Services
{
    class CategoryService : ICategoryService
    {
        private IRepository<Category> repository;
        
        public void Add(Category item)
        {
            repository.Create(item);
            if (item == null)
            {
                throw new NullReferenceException();
            }
        }

        public void Delete(Category item)
        {
            repository.Delete(item);
        }

        public Category GetById(int id)
        {
            return repository.GetById(id);
        }
    }
}
