using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMSPlugin.View
{
    public partial class CameraFeed : PictureBox
    {
        public CameraFeed() : base()
        {
            InitializeComponent();
        }

        internal void PaintAllROIs(List<ROI> rois, PaintEventArgs e)
        {
            foreach (ROI roi in rois)
            {
                e.Graphics.DrawPolygon(new Pen(roi.Color), roi.Points.ToArray());
            }
        }
    }
}
