using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = new Point();
            firstPoint.X = 10;
            firstPoint.Y = 10;
            firstPoint.DisplayStats();

            Point anotherPoint = new Point(20, 20);
            anotherPoint.DisplayStats();

            Point finalPoint = new Point { X = 30, Y = 30 };
            finalPoint.DisplayStats();

            Point pt = new Point(10, 16) { X = 100, Y = 100 };
            pt.DisplayStats();

            Point goldPoint = new Point(PointColor.Gold) { X = 90, Y = 20 };
            goldPoint.DisplayStats();

            Rectangle myRect = new Rectangle
            {
                TopLeft = new Point(PointColor.Gold) { X = 10, Y = 10 },
                BottomRight = new Point(PointColor.LightBlue) { X = 200, Y = 200 }
            };
            myRect.DisplayStats();

            //traditional approach
            Rectangle r = new Rectangle();
            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 10;
            r.TopLeft = p1;
            Point p2 = new Point();
            p2.X = 200;
            p2.Y = 200;
            r.BottomRight = p2;
            r.DisplayStats();

            Console.WriteLine();
        }
    }
}
