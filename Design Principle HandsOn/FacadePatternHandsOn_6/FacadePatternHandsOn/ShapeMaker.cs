using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternHandsOn
{
    class ShapeMaker
    {
        Shape circle;
        Shape rectangle;
        Shape square;

        public ShapeMaker() { }
        public void drawCircle()
        {
            Circle circle = new Circle();
            circle.draw();
        }
        public void drawRectangle()
        {
            Rectangle rectangle = new Rectangle();
            rectangle.draw();
        }
        public void drawSquare()
        {
            Square square = new Square();
            square.draw();
        }

    }
}
