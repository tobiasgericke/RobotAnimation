using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace RobotAnimation
{
    public class Arm : Shape
    {
        public Arm()
        {
            DefiningGeometry = new CombinedGeometry(
                //Kreis auf Mittelplattform
                //Point -> x/y des Mittelpunkts der Ellipse // Radius 10-10
                new EllipseGeometry(new Point(0, 0), 10, 10),
                //Rechteck mit Kreis am Ende
                new CombinedGeometry(
                    
                    new RectangleGeometry(new Rect(new Point(0, -10), new Size(150,20))),
                    new EllipseGeometry(new Point(150,0), 10,10)
                    )

            );
        }

        protected override Geometry DefiningGeometry { get; }
    }

    public class Greifarm : Shape
    {
        public Greifarm()
        {
            DefiningGeometry = new CombinedGeometry(
                //Kreis auf Mittelplattform
                //Point -> x/y des Mittelpunkts der Ellipse // Radius 10-10
                new EllipseGeometry(new Point(0, 0), 10, 10),
                //Rechteck mit Kreis am Ende
                new CombinedGeometry(

                    new RectangleGeometry(new Rect(new Point(0, -10), new Size(25, 20))),
                    new EllipseGeometry(new Point(150, 0), 10, 10)
                    )
            );
        }

        protected override Geometry DefiningGeometry { get; }
    }
}