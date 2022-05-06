using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMSPlugin.Model
{

    public class Shape
    {
        public List<Point> Points { get; set; }
        public Color Color;
        public float Thickness;
        public Shape()
        {
            Points = new List<Point>();
            Color = Color.White;
            Thickness = 2f;
        }
        public virtual void AddPoint(Point point)
        {
            Points.Add(point);
        }
        public virtual void RemovePoint(int index)
        {
            Points.RemoveAt(index);
        }

        public virtual bool Cover(Point point)
        {
            if (Points.Count <= 1)
                return false;

            GraphicsPath path = new GraphicsPath();

            if (Points.Count == 2)
                path.AddLine(Points[0], Points[1]);
            else
                path.AddPolygon(Points.ToArray());

            return path.IsVisible(point);
        }


    }

    public class Line : Shape
    {
        public Line()
        {
            Color = Color.Blue;
            Thickness = 2f;
        }
        public override void AddPoint(Point point)
        {
            Points.Add(point);
        }

    }

    public class Polygon : Shape
    {
        public Polygon()
        {
            Color = Color.Red;
            Thickness = 2f;
        }
        public override void AddPoint(Point point)
        {
            Points.Add(point);

            // TODO : Check for invalid shape here
        }
    }

    public class ShapeFactory
    {
        public Shape GetShape(string type)
        {
            switch (type)
            {
                case "polygon":
                    return new Polygon();
                case "line":
                    return new Line();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
