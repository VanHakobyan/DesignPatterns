using System.Drawing;
using System.Windows;


namespace Bridge
{
    // "Client"
    class Figure
    {
        public static void Draw(Window form, Shape shape, LineStyle line, Color color)
        {
            shape.implementor = line;
            shape.Draw(form, color);
        }
    }
}
