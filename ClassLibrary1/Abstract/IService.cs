using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopDomainModel.Abstract
{
    public interface IService<TEntity> where TEntity : class
    {
        void Add(TEntity item);

        void Delete(TEntity item);

        TEntity GetById(int id);
    }
}
