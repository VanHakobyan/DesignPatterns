using System.Drawing;
using System.Windows;

namespace Bridge
{
    // "Abstraction"                                                                                     
    abstract class Shape
    {
        protected Graphics graphics = null;
        protected Pen pen = null;

        public LineStyle implementor = null;

        public virtual void Draw(Window form, Color color)
        {
            
            this.pen = implementor.Draw(color);
        }
    }
}
