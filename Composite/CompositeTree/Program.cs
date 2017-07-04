using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeTree
{
    class Program
    {
        static void Main(string[] args)
        {


            Component root = new Composite("root");
            Component branch1 = new Composite("br1");
            Component branch2 = new Composite("br2");
            Component leaf1 = new Leaf("leaf1");
            Component leaf2 = new Leaf("leaf2");

            root.Add(branch1);
            root.Add(branch2);
            branch1.Add(leaf1);
            branch2.Add(leaf2);
            root.Operation();
        }
    }
}
