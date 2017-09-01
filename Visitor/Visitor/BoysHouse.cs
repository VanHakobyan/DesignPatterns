using System;

namespace Visitor
{
    internal class BoysHouse : Element
    {

        public override void Accept(Visitor visitor)
        {
            visitor.VisitBoysHouse(this);
        }

        internal void TellFairTale()
        {
            Console.WriteLine("Fair");
        }
    }
}