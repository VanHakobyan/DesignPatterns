using System;

namespace CompositeTree
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(name);
        }
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override Component GerChild(int index)
        {
            throw new NotImplementedException();
        }


        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
