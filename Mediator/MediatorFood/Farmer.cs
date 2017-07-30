using System;

namespace MediatorFood
{
    public class Farmer : Colleague
    {
        public Farmer(AbstractMediator mediator)
: base(mediator)
        {
        }
        public void GrowTomato()
        {
            string tomato = "Tomato";
            Console.WriteLine(this.GetType().Name
            + " raised " + tomato);
            mediator.Send(tomato, this);
        }
    }
}