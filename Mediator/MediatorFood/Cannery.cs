using System;

namespace MediatorFood
{
    public class Cannery
    {
        AbstractMediator mediator;
        public Cannery(AbstractMediator mediator): base(mediator)
{
        }
        public void MakeKetchup(string message)
        {
            string ketchup = message + "Ketchup";
            Console.WriteLine(this.GetType().Name
            + " produced " + ketchup);
            mediator.Send(ketchup, this);
        }
    }
}