using System.Drawing;

namespace Bridge
{
    class Triangle : Shape
    {
     
        Point[] points = new Point[]
        { 
            new Point(50, 50), 
            new Point(50, 200), 
            new Point(200, 200)            
        };

        public override void Draw(System.Windows.Window form, Color color)
        {
            base.Draw(form, color);

          
            this.graphics.DrawPolygon(pen, points);
        }
    }
}
