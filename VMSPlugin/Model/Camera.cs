using System;
using System.Collections.Generic;
using System.Drawing;
namespace VMSPlugin.Model
{
    public class Camera
    {
        public Guid ChannelID { get; }
        public List<ROI> ActiveROIs { get; }

        public string ChannelName { get; set; }
        public int VAServerIdx { get; set; }
        public int ConnectionState { get; set; }
        public int ActiveROICount { get => ActiveROIs.Count; }
        public Camera(Guid id, string name)
        {
            ActiveROIs = new List<ROI>();
            ChannelID = id;
            ChannelName = name;
            VAServerIdx = -1;
            ConnectionState = 0;

            //ROI t = new ROI("1", "1", "polygon", new ShapeFactory().GetShape("polygon"), 0, new bool[] { true }, new bool[] { true });
            //t.ROIRegion.AddPoint(new Point(1, 100));
            //t.ROIRegion.AddPoint(new Point(1, 1));
            //t.ROIRegion.AddPoint(new Point(100, 1));
            //t.ROIRegion.AddPoint(new Point(100, 100));
            //AddROI(t);
        }

        public void AddROI(ROI roi)
        {
            ActiveROIs.Add(roi);
        }

        public void RemoveROI(int index)
        {
            ActiveROIs.RemoveAt(index);
        }
        public void RemoveROI(ROI roi)
        {
            ActiveROIs.Remove(roi);
        }

        public void ClearROIs()
        {
            ActiveROIs.Clear();
        }



        public void UpdatePoint(int roiIndex, int pointIndex, Point point)
        {
            ActiveROIs[roiIndex].UpdatePoint(pointIndex, point);
        }
        public void AddPoint(int roiIndex, Point point)
        {
            ActiveROIs[roiIndex].AddPoint(point);

        }
        public void RemovePoint(int roiIndex, int pointIndex)
        {
            ActiveROIs[roiIndex].RemovePoint(pointIndex);

        }
    }
}
