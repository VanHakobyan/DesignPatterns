using System.Drawing;

namespace Bridge
{
    class Square : Shape
    {       
        public override void Draw(System.Windows.Window form, Color color)
        {
            base.Draw(form, color);

            // Нарисовать фигуру.
            //this.graphics.DrawPolygon(pen, points);
            this.graphics.DrawRectangle(pen, new Rectangle(new Point(50, 50), new Size(150, 150)));
        }
    }
}
