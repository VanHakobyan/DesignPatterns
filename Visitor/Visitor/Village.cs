using System.Collections;

namespace Visitor
{
    internal class Village
    {
        ArrayList elements = new ArrayList();


        internal void Add(Element element)
        {
            elements.Add(element);
        }
        internal void Remove(Element element)
        {
            elements.Remove(element);
        }

        internal void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
            {
                element.Accept(visitor);
            }

        }
    }
}