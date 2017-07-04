using System.Drawing;
namespace Bridge
{
    class Pentagon : Shape
    {
       
        Point[] points = new Point[]
        { 
            new Point(10, 10), 
            new Point(10, 100), 
            new Point(50, 65), 
            new Point(100, 100), 
            new Point(85, 40)          
        };

        public override void Draw(System.Windows.Window form, Color color)
        {
            base.Draw(form, color);

                   
            this.graphics.DrawPolygon(pen, points);
        }
    }
}
