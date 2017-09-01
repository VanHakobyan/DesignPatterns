using System;

namespace Visitor
{
    internal class GirlsHouse :Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitGirlsHouse(this);
        }

        internal void GiveDress()
        {
            Console.WriteLine("Dress");
        }
    }
}