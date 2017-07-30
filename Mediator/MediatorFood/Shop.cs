using System;

namespace MediatorFood
{
    public class Shop
    {
        public Shop(AbstractMediator mediator)
: base(mediator)
        {
        }
        public void SellKetchup(string message)
        {
            Console.WriteLine(GetType().Name
            + " sold " + message);
        }
    }
}