using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn_Facade
{
    public interface Shape
    {
        void draw();
    }
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Circle.");
        }
    }
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle.");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square.");
        }
    }

    public class ShapeMaker
    {
        private Shape circle;
        private Shape rectangle;
        private Shape square;

        public ShapeMaker()
        {
            circle = new Circle();
            rectangle = new Rectangle();
            square = new Square();
        }

        public void drawCircle()
        {
            circle.draw();
        }
        public void drawRectangle()
        {
            rectangle.draw();
        }
        public void drawSquare()
        {
            square.draw();
        }
    }
}
