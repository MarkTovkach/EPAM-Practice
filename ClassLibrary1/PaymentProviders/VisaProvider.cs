using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopDomainModel.Abstract;

namespace EShopDomainModel.PaymentProviders
{
   public class VisaProvider : IPaymentProvider
    {

        public bool Verify(string token)
        {
            throw new NotImplementedException();
        }

        public void SendBill(string account, decimal sum)
        {
            throw new NotImplementedException();
        }
    }
}
