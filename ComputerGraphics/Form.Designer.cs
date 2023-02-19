
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
            this.Menu = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.openGLPanel)).BeginInit();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateZRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateXRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateYRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateXRange)).BeginInit();
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
            // Menu
            // 
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.BackColor = System.Drawing.SystemColors.Info;
            this.Menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Menu.Controls.Add(this.label8);
            this.Menu.Controls.Add(this.translateZRange);
            this.Menu.Controls.Add(this.label9);
            this.Menu.Controls.Add(this.translateYRange);
            this.Menu.Controls.Add(this.label10);
            this.Menu.Controls.Add(this.translateXRange);
            this.Menu.Controls.Add(this.label7);
            this.Menu.Controls.Add(this.rotateZRange);
            this.Menu.Controls.Add(this.label6);
            this.Menu.Controls.Add(this.rotateYRange);
            this.Menu.Controls.Add(this.label5);
            this.Menu.Controls.Add(this.rotateXRange);
            this.Menu.Controls.Add(this.label4);
            this.Menu.Controls.Add(this.label3);
            this.Menu.Controls.Add(this.label2);
            this.Menu.Controls.Add(this.rndColorButton);
            this.Menu.Controls.Add(this.colorButton);
            this.Menu.Controls.Add(this.label1);
            this.Menu.Controls.Add(this.typeBox);
            this.Menu.Name = "Menu";
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
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.openGLPanel);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLPanel)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translateZRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateYRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translateXRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateZRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateYRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateXRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SharpGL.OpenGLControl openGLPanel;
        private System.Windows.Forms.Panel Menu;
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
    }
}

