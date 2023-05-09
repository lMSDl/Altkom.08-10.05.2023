using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPC.DesignPatterns.Creational.AbstractFactory;
using static WPC.DesignPatterns.Structural.Facade.II.IPaymentService;

namespace WPC.DesignPatterns.Structural.Facade.II
{
    internal class Client
    {
        public static ShopFacade ShopFacade { get; set; }
        public static void Execute()
        {

            var productIds = new int[] { 2, 3, 16 };

            ShopFacade.Buy(productIds);

        }
    }
}
