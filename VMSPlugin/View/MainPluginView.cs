using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VAPlugin;
using VideoOS.Platform;
using VideoOS.Platform.Client;
using VideoOS.Platform.UI;
using VMSPlugin.Model;
using VMSPlugin.Presentation;
using VMSPlugin.Repository;

namespace VMSPlugin
{
    public partial class VMSPluginView : OptionsDialogUserControl
    {
        private VMSPluginViewPresentation Presenter { get; set; }
        public ROI SelectedROI { get; internal set; }

        public static VMSPluginView Instance;
        public bool IsDrawing { get; set; }

        public Dictionary<VMSFunctions, CheckBox> FunctionCheckBoxDict;
        public Dictionary<VMSObjects, CheckBox> ObjectCheckBoxDict;
        public VMSPluginView()
        {
            InitializeComponent();
            Init();
            Instance = this;

            FunctionCheckBoxDict = new Dictionary<VMSFunctions, CheckBox>
            {
                { VMSFunctions.Intrusion, checkBoxIntrusion },
                { VMSFunctions.Fire, checkBoxFire },
                { VMSFunctions.Violence, checkBoxViolence },
                { VMSFunctions.WrongWay, checkBoxWrongWay },
                { VMSFunctions.LineCount, checkBoxLineCount },
                { VMSFunctions.LineCross, checkBoxLineCross },
            };

            ObjectCheckBoxDict = new Dictionary<VMSObjects, CheckBox>
            {
                { VMSObjects.Bicycle, checkBoxBicycleObj },
                { VMSObjects.Bus, checkBoxBusObj },
                { VMSObjects.Car, checkBoxCarObj },
                { VMSObjects.Motorcycle, checkBoxMotorcycleObj },
                { VMSObjects.Pedestrian, checkBoxPedestrianObj },
                { VMSObjects.Truck, checkBoxTruckObj },
            };
            
        }
        public void ShowROIs(List<ROI> rois, PaintEventArgs e)
        {
            cameraFeed.PaintAllROIs(rois, e);
        }
        public void UpdateSelectedROI(ROI roi)
        {
            SelectedROI = roi;
            labelROIIdValue.Text = roi.Id;
            textBoxROIName.Text = roi.Name;
            numericUpDownDirection.Value = roi.Direction;

            for (int i = 0; i < roi.ActiveFunctions.Count(); i++)
            {
                FunctionCheckBoxDict[(VMSFunctions)i].Checked = roi.ActiveFunctions[i];
            }

            for (int i = 0; i < roi.ActiveObjects.Count(); i++)
            {
                ObjectCheckBoxDict[(VMSObjects)i].Checked = roi.ActiveObjects[i];
            }
        }
        
        public void ShowErrorMessage(string errorMessage, string errorTitle)
        {
            MessageBox.Show(errorMessage, errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        public void EnterDrawingMode()
        {
            IsDrawing = true;
            cameraFeed.MouseMove += CameraFeedDrawingMouseMove;
        }

        public void ExitDrawingMode()
        {
            IsDrawing = false;
            cameraFeed.MouseMove -= CameraFeedDrawingMouseMove;
        }
        public void RefreshCameraFeed()
        {
            cameraFeed.Refresh();
        }
        public void UpdateCameraSettings(Camera camera)
        {
            labelChannelIdValue.Text = camera.ChannelName;
        }
        public ROI GetROIFromGUI()
        {
            bool[] activeFunction = new bool[(int) VMSFunctions.COUNT];
            ROI roi = new ROI()
            {
                ROIRegion = SelectedROI.ROIRegion,
                Direction = (int)numericUpDownDirection.Value,
                Color = SelectedROI.Color,
                Thickness = SelectedROI.Thickness,
            };

            for (int i = 0; i < activeFunction.Length; i ++)
            {
                VMSFunctions func = (VMSFunctions)i;

                if (FunctionCheckBoxDict[func].Checked)
                {
                    roi.ActivateVMSFunction(func);
                }
            }

            for (int i = 0; i < activeFunction.Length; i++)
            {
                VMSObjects obj = (VMSObjects) i;

                if (ObjectCheckBoxDict[obj].Checked)
                {
                    roi.AddVMSObject(obj);
                }
            }

            return roi;
        }
        public string GetBrushType()
        {
            if (radioButtonLineBrush.Checked)
                return "line";
            else
                return "polygon";
        }
        
        private void CameraFeedDrawingMouseMove(object sender, MouseEventArgs e)
        {
            Presenter.CameraFeedDrawingMouseMove(e.Location);
        }

        private void buttonSaveROI_Click(object sender, EventArgs e)
        {
            Presenter.SaveCameraSettings();
        }

        private void buttonRemoveROI_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveAll_Click(object sender, EventArgs e)
        {

        }

        private void CameraFeedPaint(object sender, PaintEventArgs e)
        {
            Presenter.CameraFeedPaint(e);
        }

        public override void Init()
        {
            Presenter = new VMSPluginViewPresentation(this);
        }

        private void cameraFeed_MouseDown(object sender, MouseEventArgs e)
        {
            Presenter.CameraFeedClick(e.Location);
        }

        private void checkBoxLineCross_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.FunctionCheckBoxClick(VMSFunctions.LineCross, checkBoxLineCross.Checked);
        }

        private void checkBoxIntrusion_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.FunctionCheckBoxClick(VMSFunctions.Intrusion, checkBoxIntrusion.Checked);
        }

        private void checkBoxLineCount_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.FunctionCheckBoxClick(VMSFunctions.LineCount, checkBoxLineCount.Checked);
        }

        private void checkBoxWrongWay_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.FunctionCheckBoxClick(VMSFunctions.WrongWay, checkBoxWrongWay.Checked);
        }

        private void checkBoxViolence_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.FunctionCheckBoxClick(VMSFunctions.Violence, checkBoxViolence.Checked);
        }

        private void checkBoxFire_CheckedChanged(object sender, EventArgs e)
        {
            Presenter.FunctionCheckBoxClick(VMSFunctions.Fire, checkBoxFire.Checked);
        }

        private void buttonSelectCamera_Click(object sender, EventArgs e)
        {
            Presenter.CameraSelectButtonClick();
        }
    }
}
