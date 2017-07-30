using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var farmer = new Farmer(mediator);
            var cannery = new Cannery(mediator);
            var shop = new Shop(mediator);
            mediator.Farmer = farmer;
            mediator.Cannery = cannery;
            mediator.Shop = shop;
            farmer.GrowTomato();
        }
    }
}
