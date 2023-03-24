
namespace ComputerGraphics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openGLPanel = new SharpGL.OpenGLControl();
            this.label8 = new System.Windows.Forms.Label();
            this.translateZRange = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.translateYRange = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.translateXRange = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.rotateZRange = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rotateYRange = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rotateXRange = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rndColorButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.scaleRange = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.cameraYRange = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.cameraXRange = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.dFactorBox = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sFactorBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.scissorWRange = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.scissorHRange = new System.Windows.Forms.NumericUpDown();
            this.scissorXRange = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.scissorYRange = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.alphaRefTrackBar = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.alphaTestBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.circlePartRange = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.densityChangeRange = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.densityRange = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.reductionFactorRange = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.iterationRange = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.fractalCheckBox = new System.Windows.Forms.CheckBox();
            this.xScaleFactorRange = new System.Windows.Forms.NumericUpDown();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.openGLPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateZRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateXRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateYRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateXRange)).BeginInit();
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraYRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraXRange)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scissorWRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorHRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorXRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorYRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaRefTrackBar)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePartRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityChangeRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reductionFactorRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScaleFactorRange)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLPanel
            // 
            resources.ApplyResources(this.openGLPanel, "openGLPanel");
            this.openGLPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.openGLPanel.DrawFPS = false;
            this.openGLPanel.FrameRate = 60;
            this.openGLPanel.Name = "openGLPanel";
            this.openGLPanel.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLPanel.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLPanel.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLPanel.OpenGLDraw += new SharpGL.RenderEventHandler(this.OpenGLPanel_OpenGLDraw);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // translateZRange
            // 
            this.translateZRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.translateZRange, "translateZRange");
            this.translateZRange.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.translateZRange.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.translateZRange.Name = "translateZRange";
            this.translateZRange.ValueChanged += new System.EventHandler(this.translateZRange_ValueChanged);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // translateYRange
            // 
            this.translateYRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.translateYRange, "translateYRange");
            this.translateYRange.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.translateYRange.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.translateYRange.Name = "translateYRange";
            this.translateYRange.ValueChanged += new System.EventHandler(this.translateYRange_ValueChanged);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // translateXRange
            // 
            this.translateXRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.translateXRange, "translateXRange");
            this.translateXRange.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.translateXRange.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.translateXRange.Name = "translateXRange";
            this.translateXRange.ValueChanged += new System.EventHandler(this.translateXRange_ValueChanged);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // rotateZRange
            // 
            resources.ApplyResources(this.rotateZRange, "rotateZRange");
            this.rotateZRange.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotateZRange.Name = "rotateZRange";
            this.rotateZRange.ValueChanged += new System.EventHandler(this.rotateZRange_ValueChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // rotateYRange
            // 
            resources.ApplyResources(this.rotateYRange, "rotateYRange");
            this.rotateYRange.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotateYRange.Name = "rotateYRange";
            this.rotateYRange.ValueChanged += new System.EventHandler(this.rotateYRange_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // rotateXRange
            // 
            resources.ApplyResources(this.rotateXRange, "rotateXRange");
            this.rotateXRange.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotateXRange.Name = "rotateXRange";
            this.rotateXRange.ValueChanged += new System.EventHandler(this.rotateXRange_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // rndColorButton
            // 
            resources.ApplyResources(this.rndColorButton, "rndColorButton");
            this.rndColorButton.Name = "rndColorButton";
            this.rndColorButton.UseVisualStyleBackColor = true;
            this.rndColorButton.Click += new System.EventHandler(this.rndColorButton_Click);
            // 
            // colorButton
            // 
            resources.ApplyResources(this.colorButton, "colorButton");
            this.colorButton.Name = "colorButton";
            this.colorButton.UseVisualStyleBackColor = true;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // typeBox
            // 
            resources.ApplyResources(this.typeBox, "typeBox");
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Items.AddRange(new object[] {
            resources.GetString("typeBox.Items"),
            resources.GetString("typeBox.Items1"),
            resources.GetString("typeBox.Items2"),
            resources.GetString("typeBox.Items3"),
            resources.GetString("typeBox.Items4"),
            resources.GetString("typeBox.Items5"),
            resources.GetString("typeBox.Items6"),
            resources.GetString("typeBox.Items7"),
            resources.GetString("typeBox.Items8"),
            resources.GetString("typeBox.Items9")});
            this.typeBox.Name = "typeBox";
            this.typeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // Menu
            // 
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Controls.Add(this.tabPage3);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.scaleRange);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.cameraYRange);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.cameraXRange);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.translateZRange);
            this.tabPage1.Controls.Add(this.typeBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.colorButton);
            this.tabPage1.Controls.Add(this.translateYRange);
            this.tabPage1.Controls.Add(this.rndColorButton);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.translateXRange);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rotateZRange);
            this.tabPage1.Controls.Add(this.rotateXRange);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.rotateYRange);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // scaleRange
            // 
            this.scaleRange.DecimalPlaces = 1;
            this.scaleRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.scaleRange, "scaleRange");
            this.scaleRange.Name = "scaleRange";
            this.scaleRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scaleRange.ValueChanged += new System.EventHandler(this.scaleRange_ValueChanged);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // cameraYRange
            // 
            this.cameraYRange.DecimalPlaces = 1;
            this.cameraYRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.cameraYRange, "cameraYRange");
            this.cameraYRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cameraYRange.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.cameraYRange.Name = "cameraYRange";
            this.cameraYRange.ValueChanged += new System.EventHandler(this.cameraYRange_ValueChanged);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // cameraXRange
            // 
            this.cameraXRange.DecimalPlaces = 1;
            this.cameraXRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.cameraXRange, "cameraXRange");
            this.cameraXRange.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.cameraXRange.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147483648});
            this.cameraXRange.Name = "cameraXRange";
            this.cameraXRange.ValueChanged += new System.EventHandler(this.cameraXRange_ValueChanged);
            // 
            // label23
            // 
            resources.ApplyResources(this.label23, "label23");
            this.label23.Name = "label23";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.dFactorBox);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.sFactorBox);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.scissorWRange);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.scissorHRange);
            this.tabPage2.Controls.Add(this.scissorXRange);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.scissorYRange);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.alphaRefTrackBar);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.alphaTestBox);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // dFactorBox
            // 
            resources.ApplyResources(this.dFactorBox, "dFactorBox");
            this.dFactorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dFactorBox.FormattingEnabled = true;
            this.dFactorBox.Items.AddRange(new object[] {
            resources.GetString("dFactorBox.Items"),
            resources.GetString("dFactorBox.Items1"),
            resources.GetString("dFactorBox.Items2"),
            resources.GetString("dFactorBox.Items3"),
            resources.GetString("dFactorBox.Items4"),
            resources.GetString("dFactorBox.Items5"),
            resources.GetString("dFactorBox.Items6"),
            resources.GetString("dFactorBox.Items7")});
            this.dFactorBox.Name = "dFactorBox";
            this.dFactorBox.SelectedIndexChanged += new System.EventHandler(this.dFactorBox_SelectedIndexChanged);
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // sFactorBox
            // 
            resources.ApplyResources(this.sFactorBox, "sFactorBox");
            this.sFactorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sFactorBox.FormattingEnabled = true;
            this.sFactorBox.Items.AddRange(new object[] {
            resources.GetString("sFactorBox.Items"),
            resources.GetString("sFactorBox.Items1"),
            resources.GetString("sFactorBox.Items2"),
            resources.GetString("sFactorBox.Items3"),
            resources.GetString("sFactorBox.Items4"),
            resources.GetString("sFactorBox.Items5"),
            resources.GetString("sFactorBox.Items6"),
            resources.GetString("sFactorBox.Items7"),
            resources.GetString("sFactorBox.Items8")});
            this.sFactorBox.Name = "sFactorBox";
            this.sFactorBox.SelectedIndexChanged += new System.EventHandler(this.sFactorBox_SelectedIndexChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // scissorWRange
            // 
            resources.ApplyResources(this.scissorWRange, "scissorWRange");
            this.scissorWRange.Maximum = new decimal(new int[] {
            852,
            0,
            0,
            0});
            this.scissorWRange.Name = "scissorWRange";
            this.scissorWRange.Value = new decimal(new int[] {
            852,
            0,
            0,
            0});
            this.scissorWRange.ValueChanged += new System.EventHandler(this.scissorWRange_ValueChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // scissorHRange
            // 
            resources.ApplyResources(this.scissorHRange, "scissorHRange");
            this.scissorHRange.Maximum = new decimal(new int[] {
            657,
            0,
            0,
            0});
            this.scissorHRange.Name = "scissorHRange";
            this.scissorHRange.Value = new decimal(new int[] {
            657,
            0,
            0,
            0});
            this.scissorHRange.ValueChanged += new System.EventHandler(this.scissorHRange_ValueChanged);
            // 
            // scissorXRange
            // 
            resources.ApplyResources(this.scissorXRange, "scissorXRange");
            this.scissorXRange.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.scissorXRange.Name = "scissorXRange";
            this.scissorXRange.ValueChanged += new System.EventHandler(this.scissorXRange_ValueChanged);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // scissorYRange
            // 
            resources.ApplyResources(this.scissorYRange, "scissorYRange");
            this.scissorYRange.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.scissorYRange.Name = "scissorYRange";
            this.scissorYRange.ValueChanged += new System.EventHandler(this.scissorYRange_ValueChanged);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // alphaRefTrackBar
            // 
            resources.ApplyResources(this.alphaRefTrackBar, "alphaRefTrackBar");
            this.alphaRefTrackBar.Maximum = 100;
            this.alphaRefTrackBar.Name = "alphaRefTrackBar";
            this.alphaRefTrackBar.TickFrequency = 10;
            this.alphaRefTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.alphaRefTrackBar.Scroll += new System.EventHandler(this.alphaRefTrackBar_Scroll);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // alphaTestBox
            // 
            resources.ApplyResources(this.alphaTestBox, "alphaTestBox");
            this.alphaTestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.alphaTestBox.FormattingEnabled = true;
            this.alphaTestBox.Items.AddRange(new object[] {
            resources.GetString("alphaTestBox.Items"),
            resources.GetString("alphaTestBox.Items1"),
            resources.GetString("alphaTestBox.Items2"),
            resources.GetString("alphaTestBox.Items3"),
            resources.GetString("alphaTestBox.Items4"),
            resources.GetString("alphaTestBox.Items5"),
            resources.GetString("alphaTestBox.Items6"),
            resources.GetString("alphaTestBox.Items7")});
            this.alphaTestBox.Name = "alphaTestBox";
            this.alphaTestBox.SelectedIndexChanged += new System.EventHandler(this.alphaTestBox_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Info;
            this.tabPage3.Controls.Add(this.xScaleFactorRange);
            this.tabPage3.Controls.Add(this.label29);
            this.tabPage3.Controls.Add(this.circlePartRange);
            this.tabPage3.Controls.Add(this.label28);
            this.tabPage3.Controls.Add(this.densityChangeRange);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.densityRange);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.reductionFactorRange);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.iterationRange);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.fractalCheckBox);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // circlePartRange
            // 
            this.circlePartRange.DecimalPlaces = 1;
            this.circlePartRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.circlePartRange, "circlePartRange");
            this.circlePartRange.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.circlePartRange.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.circlePartRange.Name = "circlePartRange";
            this.circlePartRange.Value = new decimal(new int[] {
            6,
            0,
            0,
            65536});
            this.circlePartRange.ValueChanged += new System.EventHandler(this.circlePartRange_ValueChanged);
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // densityChangeRange
            // 
            this.densityChangeRange.DecimalPlaces = 2;
            this.densityChangeRange.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            resources.ApplyResources(this.densityChangeRange, "densityChangeRange");
            this.densityChangeRange.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.densityChangeRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.densityChangeRange.Name = "densityChangeRange";
            this.densityChangeRange.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.densityChangeRange.ValueChanged += new System.EventHandler(this.densityChangeRange_ValueChanged);
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // densityRange
            // 
            this.densityRange.DecimalPlaces = 2;
            this.densityRange.Increment = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            resources.ApplyResources(this.densityRange, "densityRange");
            this.densityRange.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.densityRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.densityRange.Name = "densityRange";
            this.densityRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.densityRange.ValueChanged += new System.EventHandler(this.densityRange_ValueChanged);
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // reductionFactorRange
            // 
            this.reductionFactorRange.DecimalPlaces = 1;
            this.reductionFactorRange.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            resources.ApplyResources(this.reductionFactorRange, "reductionFactorRange");
            this.reductionFactorRange.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.reductionFactorRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.reductionFactorRange.Name = "reductionFactorRange";
            this.reductionFactorRange.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.reductionFactorRange.ValueChanged += new System.EventHandler(this.reductionFactorRange_ValueChanged);
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // iterationRange
            // 
            resources.ApplyResources(this.iterationRange, "iterationRange");
            this.iterationRange.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.iterationRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationRange.Name = "iterationRange";
            this.iterationRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationRange.ValueChanged += new System.EventHandler(this.iterationRange_ValueChanged);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // fractalCheckBox
            // 
            resources.ApplyResources(this.fractalCheckBox, "fractalCheckBox");
            this.fractalCheckBox.Name = "fractalCheckBox";
            this.fractalCheckBox.UseVisualStyleBackColor = true;
            this.fractalCheckBox.CheckedChanged += new System.EventHandler(this.fractalCheckBox_CheckedChanged);
            // 
            // xScaleFactorRange
            // 
            this.xScaleFactorRange.DecimalPlaces = 2;
            this.xScaleFactorRange.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            resources.ApplyResources(this.xScaleFactorRange, "xScaleFactorRange");
            this.xScaleFactorRange.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xScaleFactorRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xScaleFactorRange.Name = "xScaleFactorRange";
            this.xScaleFactorRange.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            this.xScaleFactorRange.ValueChanged += new System.EventHandler(this.xScaleFactorRange_ValueChanged);
            // 
            // label29
            // 
            resources.ApplyResources(this.label29, "label29");
            this.label29.Name = "label29";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.openGLPanel);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.openGLPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateZRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateXRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateYRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateXRange)).EndInit();
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraYRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraXRange)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scissorWRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorHRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorXRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissorYRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaRefTrackBar)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePartRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityChangeRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.densityRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reductionFactorRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xScaleFactorRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SharpGL.OpenGLControl openGLPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rndColorButton;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rotateXRange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown translateZRange;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown translateYRange;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown translateXRange;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown rotateZRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown rotateYRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown scissorXRange;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown scissorYRange;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar alphaRefTrackBar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox alphaTestBox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox dFactorBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox sFactorBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown scissorWRange;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown scissorHRange;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.NumericUpDown scaleRange;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown cameraYRange;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown cameraXRange;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox fractalCheckBox;
        private System.Windows.Forms.NumericUpDown iterationRange;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown reductionFactorRange;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.NumericUpDown densityRange;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown densityChangeRange;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown circlePartRange;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.NumericUpDown xScaleFactorRange;
        private System.Windows.Forms.Label label29;
    }
}

