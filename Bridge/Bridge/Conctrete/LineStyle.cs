using System.Drawing;

namespace Bridge
{
    // "Implementor"                                                                                         
    abstract class LineStyle
    {
        public abstract Pen Draw(Color color);
    }
}
