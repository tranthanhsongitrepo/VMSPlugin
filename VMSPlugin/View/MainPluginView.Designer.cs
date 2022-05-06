
using VMSPlugin.View;

namespace VMSPlugin
{
    partial class VMSPluginView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxROISetting = new System.Windows.Forms.GroupBox();
            this.groupBoxBrush = new System.Windows.Forms.GroupBox();
            this.radioButtonLineBrush = new System.Windows.Forms.RadioButton();
            this.radioButtonPolygonBrush = new System.Windows.Forms.RadioButton();
            this.selectCamera = new System.Windows.Forms.Button();
            this.numericUpDownDirection = new System.Windows.Forms.NumericUpDown();
            this.labelROIIdValue = new System.Windows.Forms.Label();
            this.buttonConfirmSettings = new System.Windows.Forms.Button();
            this.textBoxROIName = new System.Windows.Forms.TextBox();
            this.labelChannelIdValue = new System.Windows.Forms.Label();
            this.groupBoxObjects = new System.Windows.Forms.GroupBox();
            this.checkBoxBicycleObj = new System.Windows.Forms.CheckBox();
            this.checkBoxMotorcycleObj = new System.Windows.Forms.CheckBox();
            this.checkBoxPedestrianObj = new System.Windows.Forms.CheckBox();
            this.checkBoxBusObj = new System.Windows.Forms.CheckBox();
            this.checkBoxTruckObj = new System.Windows.Forms.CheckBox();
            this.checkBoxCarObj = new System.Windows.Forms.CheckBox();
            this.groupBoxFucntions = new System.Windows.Forms.GroupBox();
            this.checkBoxFire = new System.Windows.Forms.CheckBox();
            this.checkBoxViolence = new System.Windows.Forms.CheckBox();
            this.checkBoxWrongWay = new System.Windows.Forms.CheckBox();
            this.checkBoxIntrusion = new System.Windows.Forms.CheckBox();
            this.checkBoxLineCount = new System.Windows.Forms.CheckBox();
            this.checkBoxLineCross = new System.Windows.Forms.CheckBox();
            this.labelDirection = new System.Windows.Forms.Label();
            this.labelROIName = new System.Windows.Forms.Label();
            this.labelROIId = new System.Windows.Forms.Label();
            this.labelChannelId = new System.Windows.Forms.Label();
            this.buttonSaveROI = new System.Windows.Forms.Button();
            this.buttonRemoveROI = new System.Windows.Forms.Button();
            this.buttonRemoveAllROIs = new System.Windows.Forms.Button();
            this.cameraFeed = new VMSPlugin.View.CameraFeed();
            this.groupBoxROISetting.SuspendLayout();
            this.groupBoxBrush.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDirection)).BeginInit();
            this.groupBoxObjects.SuspendLayout();
            this.groupBoxFucntions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxROISetting
            // 
            this.groupBoxROISetting.Controls.Add(this.groupBoxBrush);
            this.groupBoxROISetting.Controls.Add(this.selectCamera);
            this.groupBoxROISetting.Controls.Add(this.numericUpDownDirection);
            this.groupBoxROISetting.Controls.Add(this.labelROIIdValue);
            this.groupBoxROISetting.Controls.Add(this.buttonConfirmSettings);
            this.groupBoxROISetting.Controls.Add(this.textBoxROIName);
            this.groupBoxROISetting.Controls.Add(this.labelChannelIdValue);
            this.groupBoxROISetting.Controls.Add(this.groupBoxObjects);
            this.groupBoxROISetting.Controls.Add(this.groupBoxFucntions);
            this.groupBoxROISetting.Controls.Add(this.labelDirection);
            this.groupBoxROISetting.Controls.Add(this.labelROIName);
            this.groupBoxROISetting.Controls.Add(this.labelROIId);
            this.groupBoxROISetting.Controls.Add(this.labelChannelId);
            this.groupBoxROISetting.Location = new System.Drawing.Point(827, 34);
            this.groupBoxROISetting.Name = "groupBoxROISetting";
            this.groupBoxROISetting.Size = new System.Drawing.Size(323, 442);
            this.groupBoxROISetting.TabIndex = 0;
            this.groupBoxROISetting.TabStop = false;
            this.groupBoxROISetting.Text = "Region Of Interest (ROI) Settings";
            // 
            // groupBoxBrush
            // 
            this.groupBoxBrush.Controls.Add(this.radioButtonLineBrush);
            this.groupBoxBrush.Controls.Add(this.radioButtonPolygonBrush);
            this.groupBoxBrush.Location = new System.Drawing.Point(9, 121);
            this.groupBoxBrush.Name = "groupBoxBrush";
            this.groupBoxBrush.Size = new System.Drawing.Size(302, 67);
            this.groupBoxBrush.TabIndex = 16;
            this.groupBoxBrush.TabStop = false;
            this.groupBoxBrush.Text = "Brush";
            // 
            // radioButtonLineBrush
            // 
            this.radioButtonLineBrush.AutoSize = true;
            this.radioButtonLineBrush.Checked = true;
            this.radioButtonLineBrush.Location = new System.Drawing.Point(13, 15);
            this.radioButtonLineBrush.Name = "radioButtonLineBrush";
            this.radioButtonLineBrush.Size = new System.Drawing.Size(75, 17);
            this.radioButtonLineBrush.TabIndex = 14;
            this.radioButtonLineBrush.TabStop = true;
            this.radioButtonLineBrush.Text = "Line Brush";
            this.radioButtonLineBrush.UseVisualStyleBackColor = true;
            // 
            // radioButtonPolygonBrush
            // 
            this.radioButtonPolygonBrush.AutoSize = true;
            this.radioButtonPolygonBrush.Location = new System.Drawing.Point(13, 38);
            this.radioButtonPolygonBrush.Name = "radioButtonPolygonBrush";
            this.radioButtonPolygonBrush.Size = new System.Drawing.Size(93, 17);
            this.radioButtonPolygonBrush.TabIndex = 15;
            this.radioButtonPolygonBrush.Text = "Polygon Brush";
            this.radioButtonPolygonBrush.UseVisualStyleBackColor = true;
            // 
            // selectCamera
            // 
            this.selectCamera.Location = new System.Drawing.Point(216, 21);
            this.selectCamera.Name = "selectCamera";
            this.selectCamera.Size = new System.Drawing.Size(95, 23);
            this.selectCamera.TabIndex = 13;
            this.selectCamera.Text = "Select Camera";
            this.selectCamera.UseVisualStyleBackColor = true;
            this.selectCamera.Click += new System.EventHandler(this.buttonSelectCamera_Click);
            // 
            // numericUpDownDirection
            // 
            this.numericUpDownDirection.Location = new System.Drawing.Point(78, 95);
            this.numericUpDownDirection.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownDirection.Name = "numericUpDownDirection";
            this.numericUpDownDirection.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownDirection.TabIndex = 12;
            // 
            // labelROIIdValue
            // 
            this.labelROIIdValue.AutoSize = true;
            this.labelROIIdValue.Location = new System.Drawing.Point(75, 45);
            this.labelROIIdValue.Name = "labelROIIdValue";
            this.labelROIIdValue.Size = new System.Drawing.Size(33, 13);
            this.labelROIIdValue.TabIndex = 11;
            this.labelROIIdValue.Text = "ID 00";
            // 
            // buttonConfirmSettings
            // 
            this.buttonConfirmSettings.Location = new System.Drawing.Point(9, 408);
            this.buttonConfirmSettings.Name = "buttonConfirmSettings";
            this.buttonConfirmSettings.Size = new System.Drawing.Size(296, 23);
            this.buttonConfirmSettings.TabIndex = 10;
            this.buttonConfirmSettings.Text = "Confirm";
            this.buttonConfirmSettings.UseVisualStyleBackColor = true;
            // 
            // textBoxROIName
            // 
            this.textBoxROIName.Location = new System.Drawing.Point(78, 66);
            this.textBoxROIName.Name = "textBoxROIName";
            this.textBoxROIName.Size = new System.Drawing.Size(233, 20);
            this.textBoxROIName.TabIndex = 8;
            // 
            // labelChannelIdValue
            // 
            this.labelChannelIdValue.AutoSize = true;
            this.labelChannelIdValue.Location = new System.Drawing.Point(75, 25);
            this.labelChannelIdValue.Name = "labelChannelIdValue";
            this.labelChannelIdValue.Size = new System.Drawing.Size(61, 13);
            this.labelChannelIdValue.TabIndex = 6;
            this.labelChannelIdValue.Text = "Channel 00";
            // 
            // groupBoxObjects
            // 
            this.groupBoxObjects.Controls.Add(this.checkBoxBicycleObj);
            this.groupBoxObjects.Controls.Add(this.checkBoxMotorcycleObj);
            this.groupBoxObjects.Controls.Add(this.checkBoxPedestrianObj);
            this.groupBoxObjects.Controls.Add(this.checkBoxBusObj);
            this.groupBoxObjects.Controls.Add(this.checkBoxTruckObj);
            this.groupBoxObjects.Controls.Add(this.checkBoxCarObj);
            this.groupBoxObjects.Location = new System.Drawing.Point(9, 300);
            this.groupBoxObjects.Name = "groupBoxObjects";
            this.groupBoxObjects.Size = new System.Drawing.Size(299, 102);
            this.groupBoxObjects.TabIndex = 5;
            this.groupBoxObjects.TabStop = false;
            this.groupBoxObjects.Text = "Objects";
            // 
            // checkBoxBicycleObj
            // 
            this.checkBoxBicycleObj.AutoSize = true;
            this.checkBoxBicycleObj.Location = new System.Drawing.Point(156, 67);
            this.checkBoxBicycleObj.Name = "checkBoxBicycleObj";
            this.checkBoxBicycleObj.Size = new System.Drawing.Size(60, 17);
            this.checkBoxBicycleObj.TabIndex = 5;
            this.checkBoxBicycleObj.Text = "Bicycle";
            this.checkBoxBicycleObj.UseVisualStyleBackColor = true;
            // 
            // checkBoxMotorcycleObj
            // 
            this.checkBoxMotorcycleObj.AutoSize = true;
            this.checkBoxMotorcycleObj.Location = new System.Drawing.Point(156, 43);
            this.checkBoxMotorcycleObj.Name = "checkBoxMotorcycleObj";
            this.checkBoxMotorcycleObj.Size = new System.Drawing.Size(78, 17);
            this.checkBoxMotorcycleObj.TabIndex = 4;
            this.checkBoxMotorcycleObj.Text = "Motorcycle";
            this.checkBoxMotorcycleObj.UseVisualStyleBackColor = true;
            // 
            // checkBoxPedestrianObj
            // 
            this.checkBoxPedestrianObj.AutoSize = true;
            this.checkBoxPedestrianObj.Location = new System.Drawing.Point(158, 19);
            this.checkBoxPedestrianObj.Name = "checkBoxPedestrianObj";
            this.checkBoxPedestrianObj.Size = new System.Drawing.Size(76, 17);
            this.checkBoxPedestrianObj.TabIndex = 3;
            this.checkBoxPedestrianObj.Text = "Pedestrian";
            this.checkBoxPedestrianObj.UseVisualStyleBackColor = true;
            // 
            // checkBoxBusObj
            // 
            this.checkBoxBusObj.AutoSize = true;
            this.checkBoxBusObj.Location = new System.Drawing.Point(8, 68);
            this.checkBoxBusObj.Name = "checkBoxBusObj";
            this.checkBoxBusObj.Size = new System.Drawing.Size(44, 17);
            this.checkBoxBusObj.TabIndex = 2;
            this.checkBoxBusObj.Text = "Bus";
            this.checkBoxBusObj.UseVisualStyleBackColor = true;
            // 
            // checkBoxTruckObj
            // 
            this.checkBoxTruckObj.AutoSize = true;
            this.checkBoxTruckObj.Location = new System.Drawing.Point(8, 44);
            this.checkBoxTruckObj.Name = "checkBoxTruckObj";
            this.checkBoxTruckObj.Size = new System.Drawing.Size(54, 17);
            this.checkBoxTruckObj.TabIndex = 1;
            this.checkBoxTruckObj.Text = "Truck";
            this.checkBoxTruckObj.UseVisualStyleBackColor = true;
            // 
            // checkBoxCarObj
            // 
            this.checkBoxCarObj.AutoSize = true;
            this.checkBoxCarObj.Location = new System.Drawing.Point(8, 20);
            this.checkBoxCarObj.Name = "checkBoxCarObj";
            this.checkBoxCarObj.Size = new System.Drawing.Size(42, 17);
            this.checkBoxCarObj.TabIndex = 0;
            this.checkBoxCarObj.Text = "Car";
            this.checkBoxCarObj.UseVisualStyleBackColor = true;
            // 
            // groupBoxFucntions
            // 
            this.groupBoxFucntions.Controls.Add(this.checkBoxFire);
            this.groupBoxFucntions.Controls.Add(this.checkBoxViolence);
            this.groupBoxFucntions.Controls.Add(this.checkBoxWrongWay);
            this.groupBoxFucntions.Controls.Add(this.checkBoxIntrusion);
            this.groupBoxFucntions.Controls.Add(this.checkBoxLineCount);
            this.groupBoxFucntions.Controls.Add(this.checkBoxLineCross);
            this.groupBoxFucntions.Location = new System.Drawing.Point(9, 194);
            this.groupBoxFucntions.Name = "groupBoxFucntions";
            this.groupBoxFucntions.Size = new System.Drawing.Size(302, 100);
            this.groupBoxFucntions.TabIndex = 4;
            this.groupBoxFucntions.TabStop = false;
            this.groupBoxFucntions.Text = "Functions";
            // 
            // checkBoxFire
            // 
            this.checkBoxFire.AutoSize = true;
            this.checkBoxFire.Location = new System.Drawing.Point(161, 66);
            this.checkBoxFire.Name = "checkBoxFire";
            this.checkBoxFire.Size = new System.Drawing.Size(92, 17);
            this.checkBoxFire.TabIndex = 5;
            this.checkBoxFire.Text = "Fire Detection";
            this.checkBoxFire.UseVisualStyleBackColor = true;
            // 
            // checkBoxViolence
            // 
            this.checkBoxViolence.AutoSize = true;
            this.checkBoxViolence.Location = new System.Drawing.Point(6, 67);
            this.checkBoxViolence.Name = "checkBoxViolence";
            this.checkBoxViolence.Size = new System.Drawing.Size(116, 17);
            this.checkBoxViolence.TabIndex = 4;
            this.checkBoxViolence.Text = "Violence Detection";
            this.checkBoxViolence.UseVisualStyleBackColor = true;
            // 
            // checkBoxWrongWay
            // 
            this.checkBoxWrongWay.AutoSize = true;
            this.checkBoxWrongWay.Location = new System.Drawing.Point(161, 43);
            this.checkBoxWrongWay.Name = "checkBoxWrongWay";
            this.checkBoxWrongWay.Size = new System.Drawing.Size(132, 17);
            this.checkBoxWrongWay.TabIndex = 3;
            this.checkBoxWrongWay.Text = "Wrong Way Detection";
            this.checkBoxWrongWay.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntrusion
            // 
            this.checkBoxIntrusion.AutoSize = true;
            this.checkBoxIntrusion.Location = new System.Drawing.Point(161, 19);
            this.checkBoxIntrusion.Name = "checkBoxIntrusion";
            this.checkBoxIntrusion.Size = new System.Drawing.Size(115, 17);
            this.checkBoxIntrusion.TabIndex = 2;
            this.checkBoxIntrusion.Text = "Intrusion Detection";
            this.checkBoxIntrusion.UseVisualStyleBackColor = true;
            // 
            // checkBoxLineCount
            // 
            this.checkBoxLineCount.AutoSize = true;
            this.checkBoxLineCount.Location = new System.Drawing.Point(8, 44);
            this.checkBoxLineCount.Name = "checkBoxLineCount";
            this.checkBoxLineCount.Size = new System.Drawing.Size(77, 17);
            this.checkBoxLineCount.TabIndex = 1;
            this.checkBoxLineCount.Text = "Line Count";
            this.checkBoxLineCount.UseVisualStyleBackColor = true;
            // 
            // checkBoxLineCross
            // 
            this.checkBoxLineCross.AutoSize = true;
            this.checkBoxLineCross.Location = new System.Drawing.Point(8, 20);
            this.checkBoxLineCross.Name = "checkBoxLineCross";
            this.checkBoxLineCross.Size = new System.Drawing.Size(124, 17);
            this.checkBoxLineCross.TabIndex = 0;
            this.checkBoxLineCross.Text = "Line Cross Detection";
            this.checkBoxLineCross.UseVisualStyleBackColor = true;
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(6, 95);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(52, 13);
            this.labelDirection.TabIndex = 3;
            this.labelDirection.Text = "Direction:";
            // 
            // labelROIName
            // 
            this.labelROIName.AutoSize = true;
            this.labelROIName.Location = new System.Drawing.Point(6, 69);
            this.labelROIName.Name = "labelROIName";
            this.labelROIName.Size = new System.Drawing.Size(60, 13);
            this.labelROIName.TabIndex = 2;
            this.labelROIName.Text = "ROI Name:";
            // 
            // labelROIId
            // 
            this.labelROIId.AutoSize = true;
            this.labelROIId.Location = new System.Drawing.Point(6, 45);
            this.labelROIId.Name = "labelROIId";
            this.labelROIId.Size = new System.Drawing.Size(43, 13);
            this.labelROIId.TabIndex = 1;
            this.labelROIId.Text = "ROI ID:";
            // 
            // labelChannelId
            // 
            this.labelChannelId.AutoSize = true;
            this.labelChannelId.Location = new System.Drawing.Point(6, 26);
            this.labelChannelId.Name = "labelChannelId";
            this.labelChannelId.Size = new System.Drawing.Size(63, 13);
            this.labelChannelId.TabIndex = 0;
            this.labelChannelId.Text = "Channel ID:";
            // 
            // buttonSaveROI
            // 
            this.buttonSaveROI.Location = new System.Drawing.Point(539, 442);
            this.buttonSaveROI.Name = "buttonSaveROI";
            this.buttonSaveROI.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveROI.TabIndex = 1;
            this.buttonSaveROI.Text = "Save ROI";
            this.buttonSaveROI.UseVisualStyleBackColor = true;
            this.buttonSaveROI.Click += new System.EventHandler(this.buttonSaveROI_Click);
            // 
            // buttonRemoveROI
            // 
            this.buttonRemoveROI.Location = new System.Drawing.Point(620, 442);
            this.buttonRemoveROI.Name = "buttonRemoveROI";
            this.buttonRemoveROI.Size = new System.Drawing.Size(120, 23);
            this.buttonRemoveROI.TabIndex = 2;
            this.buttonRemoveROI.Text = "Remove ROI";
            this.buttonRemoveROI.UseVisualStyleBackColor = true;
            this.buttonRemoveROI.Click += new System.EventHandler(this.buttonRemoveROI_Click);
            // 
            // buttonRemoveAllROIs
            // 
            this.buttonRemoveAllROIs.Location = new System.Drawing.Point(746, 442);
            this.buttonRemoveAllROIs.Name = "buttonRemoveAllROIs";
            this.buttonRemoveAllROIs.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAllROIs.TabIndex = 3;
            this.buttonRemoveAllROIs.Text = "Remove All";
            this.buttonRemoveAllROIs.UseVisualStyleBackColor = true;
            this.buttonRemoveAllROIs.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // cameraFeed
            // 
            this.cameraFeed.Location = new System.Drawing.Point(12, 34);
            this.cameraFeed.Name = "cameraFeed";
            this.cameraFeed.Size = new System.Drawing.Size(809, 402);
            this.cameraFeed.TabIndex = 4;
            this.cameraFeed.TabStop = false;
            this.cameraFeed.Paint += new System.Windows.Forms.PaintEventHandler(this.CameraFeedPaint);
            this.cameraFeed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cameraFeed_MouseDown);
            // 
            // VMSPluginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cameraFeed);
            this.Controls.Add(this.buttonRemoveAllROIs);
            this.Controls.Add(this.buttonRemoveROI);
            this.Controls.Add(this.buttonSaveROI);
            this.Controls.Add(this.groupBoxROISetting);
            this.Name = "VMSPluginView";
            this.Size = new System.Drawing.Size(1160, 514);
            this.groupBoxROISetting.ResumeLayout(false);
            this.groupBoxROISetting.PerformLayout();
            this.groupBoxBrush.ResumeLayout(false);
            this.groupBoxBrush.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDirection)).EndInit();
            this.groupBoxObjects.ResumeLayout(false);
            this.groupBoxObjects.PerformLayout();
            this.groupBoxFucntions.ResumeLayout(false);
            this.groupBoxFucntions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraFeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxROISetting;
        private System.Windows.Forms.GroupBox groupBoxFucntions;
        private System.Windows.Forms.CheckBox checkBoxLineCross;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.Label labelROIName;
        private System.Windows.Forms.Label labelROIId;
        private System.Windows.Forms.Label labelChannelId;
        private System.Windows.Forms.CheckBox checkBoxWrongWay;
        private System.Windows.Forms.CheckBox checkBoxIntrusion;
        private System.Windows.Forms.CheckBox checkBoxLineCount;
        private System.Windows.Forms.GroupBox groupBoxObjects;
        private System.Windows.Forms.CheckBox checkBoxBicycleObj;
        private System.Windows.Forms.CheckBox checkBoxMotorcycleObj;
        private System.Windows.Forms.CheckBox checkBoxPedestrianObj;
        private System.Windows.Forms.CheckBox checkBoxBusObj;
        private System.Windows.Forms.CheckBox checkBoxTruckObj;
        private System.Windows.Forms.CheckBox checkBoxCarObj;
        private System.Windows.Forms.CheckBox checkBoxViolence;
        private System.Windows.Forms.CheckBox checkBoxFire;
        private System.Windows.Forms.Label labelChannelIdValue;
        private System.Windows.Forms.TextBox textBoxROIName;
        private System.Windows.Forms.Button buttonConfirmSettings;
        private System.Windows.Forms.Button buttonSaveROI;
        private System.Windows.Forms.Button buttonRemoveROI;
        private System.Windows.Forms.Button buttonRemoveAllROIs;
        private CameraFeed cameraFeed;
        private System.Windows.Forms.Label labelROIIdValue;
        private System.Windows.Forms.NumericUpDown numericUpDownDirection;
        private System.Windows.Forms.Button selectCamera;
        private System.Windows.Forms.GroupBox groupBoxBrush;
        private System.Windows.Forms.RadioButton radioButtonLineBrush;
        private System.Windows.Forms.RadioButton radioButtonPolygonBrush;
    }
}

