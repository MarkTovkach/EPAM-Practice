using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Entities;

namespace EShopDomainModel.Abstract
{
    public interface IPaymentService
    {
        void Pay(ShopingCart cart);
        void CheckPayment(ShopingCart cart);
    }
}
