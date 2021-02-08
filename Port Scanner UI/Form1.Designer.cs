
namespace Port_Scanner_UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.lblIprange = new DevExpress.XtraEditors.LabelControl();
            this.txtIprangeMin = new DevExpress.XtraEditors.TextEdit();
            this.txtIprangeMax = new DevExpress.XtraEditors.TextEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.trckBarThreadCount = new DevExpress.XtraEditors.TrackBarControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblThreadCounter = new DevExpress.XtraEditors.LabelControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.richEditCommentControl1 = new DevExpress.XtraRichEdit.RichEditCommentControl();
            this.rtxtConsole = new System.Windows.Forms.RichTextBox();
            this.lblConsole = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.radioRange = new System.Windows.Forms.RadioButton();
            this.radioNotation = new System.Windows.Forms.RadioButton();
            this.txtIpNotation = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIprangeMin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIprangeMax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarThreadCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIpNotation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.Location = new System.Drawing.Point(55, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Scan";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Appearance.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStop.Appearance.Options.UseFont = true;
            this.btnStop.Location = new System.Drawing.Point(197, 127);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop Scan";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblIprange
            // 
            this.lblIprange.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIprange.Appearance.Options.UseFont = true;
            this.lblIprange.Location = new System.Drawing.Point(54, 4);
            this.lblIprange.Name = "lblIprange";
            this.lblIprange.Size = new System.Drawing.Size(63, 19);
            this.lblIprange.TabIndex = 2;
            this.lblIprange.Text = "IP Range";
            // 
            // txtIprangeMin
            // 
            this.txtIprangeMin.EditValue = "127.0.0.1";
            this.txtIprangeMin.Location = new System.Drawing.Point(54, 79);
            this.txtIprangeMin.Name = "txtIprangeMin";
            this.txtIprangeMin.Properties.BeepOnError = false;
            this.txtIprangeMin.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtIprangeMin.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtIprangeMin.Properties.MaskSettings.Set("mask", "([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9" +
        "]|2[0-4][0-9]|25[0-5])){3}");
            this.txtIprangeMin.Properties.NullText = "0.0.0.0";
            this.txtIprangeMin.Size = new System.Drawing.Size(100, 20);
            this.txtIprangeMin.TabIndex = 3;
            // 
            // txtIprangeMax
            // 
            this.txtIprangeMax.EditValue = "127.0.0.2";
            this.txtIprangeMax.Location = new System.Drawing.Point(196, 79);
            this.txtIprangeMax.Name = "txtIprangeMax";
            this.txtIprangeMax.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtIprangeMax.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtIprangeMax.Properties.MaskSettings.Set("mask", "([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9" +
        "]|2[0-4][0-9]|25[0-5])){3}");
            this.txtIprangeMax.Properties.MaskSettings.Set("showPlaceholders", false);
            this.txtIprangeMax.Properties.NullText = "0.0.0.0";
            this.txtIprangeMax.Size = new System.Drawing.Size(100, 20);
            this.txtIprangeMax.TabIndex = 4;
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(-9, 156);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(1078, 23);
            this.separatorControl1.TabIndex = 5;
            // 
            // trckBarThreadCount
            // 
            this.trckBarThreadCount.EditValue = 1;
            this.trckBarThreadCount.Location = new System.Drawing.Point(472, 77);
            this.trckBarThreadCount.Name = "trckBarThreadCount";
            this.trckBarThreadCount.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trckBarThreadCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.trckBarThreadCount.Properties.LookAndFeel.SkinName = "DevExpress Style";
            this.trckBarThreadCount.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.trckBarThreadCount.Properties.Maximum = 50;
            this.trckBarThreadCount.Properties.Minimum = 1;
            this.trckBarThreadCount.Properties.ShowLabels = true;
            this.trckBarThreadCount.Properties.ShowLabelsForHiddenTicks = true;
            this.trckBarThreadCount.Properties.ShowValueToolTip = true;
            this.trckBarThreadCount.Size = new System.Drawing.Size(348, 45);
            this.trckBarThreadCount.TabIndex = 6;
            this.trckBarThreadCount.Value = 1;
            this.trckBarThreadCount.EditValueChanged += new System.EventHandler(this.trckBarThreadCount_EditValueChanged);
            this.trckBarThreadCount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trckBarThreadCount_MouseUp);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(169, 77);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(7, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "-";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(472, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(101, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Thread Count :";
            // 
            // lblThreadCounter
            // 
            this.lblThreadCounter.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblThreadCounter.Appearance.Options.UseFont = true;
            this.lblThreadCounter.Location = new System.Drawing.Point(579, 46);
            this.lblThreadCounter.Name = "lblThreadCounter";
            this.lblThreadCounter.Size = new System.Drawing.Size(8, 19);
            this.lblThreadCounter.TabIndex = 9;
            this.lblThreadCounter.Text = "1";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(632, 384);
            this.dockPanel1.ID = new System.Guid("ef6dcd24-caa9-4f65-9fd7-a51f181b0659");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(361, 200);
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "Main document comments";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.richEditCommentControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 171);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // richEditCommentControl1
            // 
            this.richEditCommentControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditCommentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditCommentControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditCommentControl1.Name = "richEditCommentControl1";
            this.richEditCommentControl1.ReadOnly = false;
            this.richEditCommentControl1.RichEditControl = null;
            this.richEditCommentControl1.Size = new System.Drawing.Size(192, 171);
            this.richEditCommentControl1.TabIndex = 0;
            // 
            // rtxtConsole
            // 
            this.rtxtConsole.BackColor = System.Drawing.SystemColors.WindowText;
            this.rtxtConsole.ForeColor = System.Drawing.Color.Lime;
            this.rtxtConsole.Location = new System.Drawing.Point(55, 210);
            this.rtxtConsole.Name = "rtxtConsole";
            this.rtxtConsole.ReadOnly = true;
            this.rtxtConsole.Size = new System.Drawing.Size(889, 242);
            this.rtxtConsole.TabIndex = 10;
            this.rtxtConsole.Text = "";
            this.rtxtConsole.TextChanged += new System.EventHandler(this.rtxtConsole_TextChanged);
            // 
            // lblConsole
            // 
            this.lblConsole.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConsole.Appearance.Options.UseFont = true;
            this.lblConsole.Location = new System.Drawing.Point(54, 185);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(58, 19);
            this.lblConsole.TabIndex = 11;
            this.lblConsole.Text = "Console ";
            // 
            // radioGroup1
            // 
            this.radioGroup1.Location = new System.Drawing.Point(54, 29);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Size = new System.Drawing.Size(202, 36);
            this.radioGroup1.TabIndex = 12;
            // 
            // radioRange
            // 
            this.radioRange.AutoSize = true;
            this.radioRange.Checked = true;
            this.radioRange.Location = new System.Drawing.Point(55, 36);
            this.radioRange.Name = "radioRange";
            this.radioRange.Size = new System.Drawing.Size(69, 17);
            this.radioRange.TabIndex = 13;
            this.radioRange.TabStop = true;
            this.radioRange.Text = "Ip Range";
            this.radioRange.UseVisualStyleBackColor = true;
            this.radioRange.CheckedChanged += new System.EventHandler(this.radioRange_CheckedChanged);
            // 
            // radioNotation
            // 
            this.radioNotation.AutoSize = true;
            this.radioNotation.Location = new System.Drawing.Point(148, 36);
            this.radioNotation.Name = "radioNotation";
            this.radioNotation.Size = new System.Drawing.Size(77, 17);
            this.radioNotation.TabIndex = 14;
            this.radioNotation.Text = "Ip Notation";
            this.radioNotation.UseVisualStyleBackColor = true;
            this.radioNotation.CheckedChanged += new System.EventHandler(this.radioNotation_CheckedChanged);
            // 
            // txtIpNotation
            // 
            this.txtIpNotation.EditValue = "193.140.140.104/24";
            this.txtIpNotation.Location = new System.Drawing.Point(54, 79);
            this.txtIpNotation.Name = "txtIpNotation";
            this.txtIpNotation.Properties.BeepOnError = false;
            this.txtIpNotation.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtIpNotation.Properties.MaskSettings.Set("mask", "([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\\.([0-9]|[1-9][0-9]|1[0-9][0-9" +
        "]|2[0-4][0-9]|25[0-5])){3,3}([\\/[0-9][0-9][0-9])");
            this.txtIpNotation.Size = new System.Drawing.Size(122, 20);
            this.txtIpNotation.TabIndex = 15;
            this.txtIpNotation.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 474);
            this.Controls.Add(this.txtIpNotation);
            this.Controls.Add(this.radioNotation);
            this.Controls.Add(this.radioRange);
            this.Controls.Add(this.radioGroup1);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.rtxtConsole);
            this.Controls.Add(this.trckBarThreadCount);
            this.Controls.Add(this.lblThreadCounter);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.txtIprangeMax);
            this.Controls.Add(this.txtIprangeMin);
            this.Controls.Add(this.lblIprange);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Port Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.txtIprangeMin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIprangeMax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarThreadCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarThreadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIpNotation.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.LabelControl lblIprange;
        private DevExpress.XtraEditors.TextEdit txtIprangeMin;
        private DevExpress.XtraEditors.TextEdit txtIprangeMax;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TrackBarControl trckBarThreadCount;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblThreadCounter;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraRichEdit.RichEditCommentControl richEditCommentControl1;
        private DevExpress.XtraEditors.LabelControl lblConsole;
        private System.Windows.Forms.RichTextBox rtxtConsole;
        private System.Windows.Forms.RadioButton radioNotation;
        private System.Windows.Forms.RadioButton radioRange;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit txtIpNotation;
    }
}

