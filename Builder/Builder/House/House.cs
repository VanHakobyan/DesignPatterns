using System;
using System.Collections;

namespace Builder.House
{
    class House
    {
        ArrayList lists = new ArrayList();
        public void Add(object o)
        {
            lists.Add(o);
        }
    }
}
