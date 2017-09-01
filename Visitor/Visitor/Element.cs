namespace Visitor
{
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}