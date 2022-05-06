using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using VMSPlugin.Model;

namespace VMSPlugin
{
    public class ROI
    {
        // TODO: If Line in VMSFunction then VMSFunction should only contains Line
        public string Id { get; set; }
        public string Name { get; set; }
        
        public Shape ROIRegion { get; set; }
        public int Direction { get; set; }
        public bool[] ActiveFunctions { get; }
        public bool[] ActiveObjects { get; }
        public virtual Color Color { get; set; }
        public virtual float Thickness { get; set; } = 2;
        [JsonIgnore]

        public List<Point> Points
        {
            get
            {
                return ROIRegion.Points;
            }
        }
        [JsonIgnore]

        public int PointCount { get => Points.Count; }

        public ROI(string id, string name, Shape roiRegion, int direction, bool[] activeFunctions, bool[] activeObjects)
        {
            Id = id;
            Name = name;
            ROIRegion = roiRegion;
            Direction = direction;
            ActiveFunctions = activeFunctions;
            ActiveObjects = activeObjects;
            Color = roiRegion.Color;
            Thickness = roiRegion.Thickness;
        }

        public ROI()
        {
            Direction = 0;
            ActiveFunctions = new bool[(int)VMSFunctions.COUNT];
            ActiveObjects = new bool[(int)VMSObjects.COUNT];

            Color = Color.White;
        }

        public void RemovePoint(int index)
        {
            ROIRegion.RemovePoint(index);
        }
        public void AddPoint(Point point)
        {
            ROIRegion.AddPoint(point);
        }

        public void UpdatePoint(int index, Point point)
        {
            Points[index] = point;
        }

        public void AddVMSObject(VMSObjects vmsObject)
        {
            ActiveObjects[(int)vmsObject] = true;
        }

        public void RemoveVMSObject(VMSObjects vmsObject)
        {
            ActiveObjects[(int)vmsObject] = false;
        }

        public void ActivateVMSFunction(VMSFunctions vmsFunction)
        {
            ActiveFunctions[(int)vmsFunction] = true;
        }

        public void DeactivateVMSFunction(VMSFunctions vmsFunction)
        {
            ActiveFunctions[(int)vmsFunction] = false;
        }

        public bool Cover(Point point)
        {
            return ROIRegion.Cover(point);
        }
        private double FindDistanceToPoint(Point pt1, Point pt2)
        {
            double dx = pt1.X - pt2.X;
            double dy = pt1.Y - pt2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public (double, int) MinDistanceToPoint(Point point)
        {
            double minDist = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < ROIRegion.Points.Count; i++)
            {
                Point roiPoint = ROIRegion.Points[i];
                double dist = FindDistanceToPoint(roiPoint, point);
                if (dist < minDist)
                {
                    minDist = dist;
                    minIndex = i;
                }
            }

            return (minDist, minIndex);
        }

    }
    
    public class LineROI : ROI
    {
        public LineROI() : base()
        {
            ROIRegion = new Line();

            Color = ROIRegion.Color;
            Thickness = ROIRegion.Thickness;
        }
    }

    public class PolygonROI : ROI
    {
        public PolygonROI() : base()
        {
            ROIRegion = new Polygon();

            Color = ROIRegion.Color;
            Thickness = ROIRegion.Thickness;
        }
    }

    public class ROIFactory
    {
        public ROI GetROI(string name)
        {
            switch (name)
            {
                case "line":
                    return new LineROI();
                case "polygon":
                    return new PolygonROI();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
