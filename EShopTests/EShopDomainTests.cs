using System;
using System.Collections.Generic;
using EShopDomainModel.Abstract;
using EShopDomainModel.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;

namespace EShopTests
{
    [TestClass]
    public class EShopDomainTests
    {
        [TestMethod]
        public void Add_Product_To_Cart()
        {
            //arrange
            IShopingCartService shopingCartService = MockRepository.GenerateMock<IShopingCartService>();
            IDiscountService discountService = MockRepository.GenerateMock<IDiscountService>();


            ShopingCart cart = new ShopingCart();
            Discount discount = new Discount();
            Items item = new Items();

            //act
            shopingCartService.Add(item);

            //assert
            Assert.AreEqual(1,cart.PurchaseItems.Count);
            
        }
    }
}
