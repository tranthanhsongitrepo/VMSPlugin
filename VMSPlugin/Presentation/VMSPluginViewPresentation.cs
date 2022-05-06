using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAPlugin;
using VMSPlugin.Repository;
using MySqlConnector;
using System.Drawing;
using VideoOS.Platform;
using VMSPlugin.Model;
using VideoOS.Platform.UI;

namespace VMSPlugin.Presentation
{
    class VMSPluginViewPresentation 
    {
        private VMSPluginView MainPluginView { get; }
        private CameraRepository CameraRepository { get; set; }
        private Camera ActiveCamera { get; set; }
        public VMSPluginViewPresentation(VMSPluginView mainPluginView)
        {
            MainPluginView = mainPluginView;
            CameraRepository = new CameraRepository();
            CameraSelectButtonClick();
        }
        public ROI GetSelectedROI(Point location)
        {
            List<ROI> activeROIs = ActiveCamera.ActiveROIs;

            for (int i = 0; i < activeROIs.Count; i++)
            {
                ROI roi = activeROIs[i];
                if (roi.Cover(location))
                {
                    return roi;
                }
            }

            return null;
        }

        public void SaveCameraSettings()
        {
            CameraRepository.Save(ActiveCamera);
        }

        public void CameraFeedPaint(PaintEventArgs e)
        {
            MainPluginView.ShowROIs(ActiveCamera.ActiveROIs, e);
        }
        
        public void RemoveROI(Point location)
        {
            ROI roi = GetSelectedROI(location);
            ActiveCamera.RemoveROI(roi);
        }

        public void RemoveAllROIs()
        {
            ActiveCamera.ClearROIs();
        }
        public void CameraSelectButtonClick()
        {
            ItemPickerForm form = new ItemPickerForm
            {
                KindFilter = Kind.Camera,
                AutoAccept = true
            };
            form.Init();
            if (form.ShowDialog() == DialogResult.OK)
            {
                ActiveCamera = CameraRepository.GetById(form.SelectedItem.FQID.ObjectId);

                if (ActiveCamera == null)
                    ActiveCamera = new Camera(form.SelectedItem.FQID.ObjectId, form.SelectedItem.Name);

                MainPluginView.UpdateCameraSettings(ActiveCamera);
            }
        }
        public void CameraFeedDrawingMouseMove(Point location)
        {
            ROI roi = ActiveCamera.ActiveROIs.Last();
            ActiveCamera.UpdatePoint(ActiveCamera.ActiveROICount - 1, roi.PointCount - 1, location);
            MainPluginView.RefreshCameraFeed();
        }

        public void CameraFeedClick(Point location)
        {
            if (!MainPluginView.IsDrawing)
            {
                ROI hitROI = GetSelectedROI(location);

                if (hitROI != null)
                {
                    MainPluginView.UpdateSelectedROI(hitROI);
                }
                else
                {
                    ActiveCamera.AddROI(new ROIFactory().GetROI(MainPluginView.GetBrushType()));
                    ActiveCamera.AddPoint(ActiveCamera.ActiveROICount - 1, location);
                    ActiveCamera.AddPoint(ActiveCamera.ActiveROICount - 1, location);

                    MainPluginView.EnterDrawingMode();
                }
            }
            else
            {
                ROI newROI = ActiveCamera.ActiveROIs.Last();
                ActiveCamera.RemovePoint(ActiveCamera.ActiveROICount - 1, newROI.PointCount - 1);

                if (newROI.GetType() == typeof(PolygonROI))
                {
                    (double dist, int index) = newROI.MinDistanceToPoint(location);

                    if (dist < 20 && index != -1)
                    {
                        MainPluginView.UpdateSelectedROI(ActiveCamera.ActiveROIs.Last());
                        MainPluginView.ExitDrawingMode();
                    }
                    else
                    {
                        ActiveCamera.AddPoint(ActiveCamera.ActiveROICount - 1, location);
                        ActiveCamera.AddPoint(ActiveCamera.ActiveROICount - 1, location);
                    }
                }
                else
                {
                    ActiveCamera.AddPoint(ActiveCamera.ActiveROICount - 1, location);
                    MainPluginView.ExitDrawingMode();
                }

            }
        }

        public void FunctionCheckBoxClick(VMSFunctions vmsFunction, bool boxChecked)
        {
            ROI selectedROI = MainPluginView.SelectedROI;

            if (selectedROI == null)
            {
                MainPluginView.ShowErrorMessage("Please select a ROI first", "No ROIs selected");
                return;
            }

            if (boxChecked)
            {
                selectedROI.ActivateVMSFunction(vmsFunction);
            }
            else
            {
                selectedROI.DeactivateVMSFunction(vmsFunction);
            }
        }
    }
}
