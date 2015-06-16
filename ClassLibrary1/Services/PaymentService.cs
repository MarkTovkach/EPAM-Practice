using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;
using EShopDomainModel.PaymentProviders;

namespace EShopDomainModel.Services
{
    public class PaymentService : IPaymentService
    {
        private IPaymentProvider paymentProvider;
        public void Pay(ShopingCart cart)
        {
            paymentProvider.SendBill(accountMarkTovkach, cart.Sum);
        }

        public void CheckPayment(ShopingCart cart)
        {
            if (paymentProvider.Verify(token))
                cart.Status = OrderStatus.Payed;
        }

        //stubs
        public string accountMarkTovkach;
        public string token;
    }
}
