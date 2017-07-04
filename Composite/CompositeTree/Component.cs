namespace CompositeTree
{
  abstract  class Component
    {
        protected string name;
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GerChild(int index);

    }
}
