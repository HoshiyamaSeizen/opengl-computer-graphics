namespace Cubic_Bezier {
    partial class Form {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            openglControl3D = new SharpGL.OpenGLControl();
            openglControl = new SharpGL.OpenGLControl();
            PhiTrackBar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ThetaTrackBar = new TrackBar();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AmbientCheckBox = new CheckBox();
            DiffuseCheckBox = new CheckBox();
            SpecularCheckBox = new CheckBox();
            label7 = new Label();
            label8 = new Label();
            aStrengthTrackBar = new TrackBar();
            label9 = new Label();
            dStrengthTrackBar = new TrackBar();
            label10 = new Label();
            sStrengthTrackBar = new TrackBar();
            label11 = new Label();
            ShininessTrackBar = new TrackBar();
            lightColorButton = new Button();
            label12 = new Label();
            label13 = new Label();
            objColorButton = new Button();
            AnimationCheckBox = new CheckBox();
            lightColorDialog = new ColorDialog();
            objColorDialog = new ColorDialog();
            label14 = new Label();
            typeBox = new ComboBox();
            label15 = new Label();
            lightTypeBox = new ComboBox();
            gridCheckBox = new CheckBox();
            axesCheckBox = new CheckBox();
            structureCheckBox = new CheckBox();
            label16 = new Label();
            label17 = new Label();
            densityTrackBar = new TrackBar();
            label18 = new Label();
            fovTrackBar = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)openglControl3D).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openglControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhiTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThetaTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)aStrengthTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dStrengthTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sStrengthTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ShininessTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densityTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fovTrackBar).BeginInit();
            SuspendLayout();
            // 
            // openglControl3D
            // 
            openglControl3D.DrawFPS = false;
            openglControl3D.FrameRate = 60;
            openglControl3D.Location = new Point(0, 466);
            openglControl3D.Margin = new Padding(0);
            openglControl3D.Name = "openglControl3D";
            openglControl3D.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            openglControl3D.RenderContextType = SharpGL.RenderContextType.FBO;
            openglControl3D.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            openglControl3D.Size = new Size(863, 440);
            openglControl3D.TabIndex = 0;
            openglControl3D.OpenGLDraw += openglControl3D_OpenGLDraw;
            openglControl3D.MouseMove += openglControl3D_MouseMove;
            // 
            // openglControl
            // 
            openglControl.DrawFPS = false;
            openglControl.FrameRate = 60;
            openglControl.Location = new Point(0, 0);
            openglControl.Margin = new Padding(0);
            openglControl.Name = "openglControl";
            openglControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            openglControl.RenderContextType = SharpGL.RenderContextType.FBO;
            openglControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            openglControl.Size = new Size(863, 440);
            openglControl.TabIndex = 0;
            openglControl.OpenGLDraw += openglControl_OpenGLDraw;
            openglControl.MouseDown += openglControl_MouseDown;
            openglControl.MouseMove += openglControl_MouseMove;
            openglControl.MouseUp += openglControl_MouseUp;
            // 
            // PhiTrackBar
            // 
            PhiTrackBar.ImeMode = ImeMode.NoControl;
            PhiTrackBar.Location = new Point(958, 121);
            PhiTrackBar.Maximum = 180;
            PhiTrackBar.Minimum = -180;
            PhiTrackBar.Name = "PhiTrackBar";
            PhiTrackBar.Size = new Size(264, 56);
            PhiTrackBar.TabIndex = 5;
            PhiTrackBar.TickFrequency = 20;
            PhiTrackBar.TickStyle = TickStyle.TopLeft;
            PhiTrackBar.ValueChanged += PhiTrackBar_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1001, 31);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 6;
            label1.Text = "Light Source";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(891, 132);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Azimuth:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(884, 184);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Inclination:";
            // 
            // ThetaTrackBar
            // 
            ThetaTrackBar.ImeMode = ImeMode.NoControl;
            ThetaTrackBar.Location = new Point(958, 175);
            ThetaTrackBar.Maximum = 180;
            ThetaTrackBar.Name = "ThetaTrackBar";
            ThetaTrackBar.Size = new Size(264, 56);
            ThetaTrackBar.TabIndex = 8;
            ThetaTrackBar.TickFrequency = 10;
            ThetaTrackBar.TickStyle = TickStyle.TopLeft;
            ThetaTrackBar.Value = 90;
            ThetaTrackBar.ValueChanged += ThetaTrackBar_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(999, 437);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 10;
            label4.Text = "Ambient Light";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(1005, 592);
            label5.Name = "label5";
            label5.Size = new Size(121, 28);
            label5.TabIndex = 11;
            label5.Text = "Diffuse Light";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(1001, 742);
            label6.Name = "label6";
            label6.Size = new Size(136, 28);
            label6.TabIndex = 12;
            label6.Text = "Specular Light";
            // 
            // AmbientCheckBox
            // 
            AmbientCheckBox.AutoSize = true;
            AmbientCheckBox.Checked = true;
            AmbientCheckBox.CheckState = CheckState.Checked;
            AmbientCheckBox.Location = new Point(1027, 485);
            AmbientCheckBox.Name = "AmbientCheckBox";
            AmbientCheckBox.Size = new Size(85, 24);
            AmbientCheckBox.TabIndex = 13;
            AmbientCheckBox.Text = "Enabled";
            AmbientCheckBox.UseVisualStyleBackColor = true;
            AmbientCheckBox.CheckedChanged += AmbientCheckBox_CheckedChanged;
            // 
            // DiffuseCheckBox
            // 
            DiffuseCheckBox.AutoSize = true;
            DiffuseCheckBox.Checked = true;
            DiffuseCheckBox.CheckState = CheckState.Checked;
            DiffuseCheckBox.Location = new Point(1027, 635);
            DiffuseCheckBox.Name = "DiffuseCheckBox";
            DiffuseCheckBox.Size = new Size(85, 24);
            DiffuseCheckBox.TabIndex = 14;
            DiffuseCheckBox.Text = "Enabled";
            DiffuseCheckBox.UseVisualStyleBackColor = true;
            DiffuseCheckBox.CheckedChanged += DiffuseCheckBox_CheckedChanged;
            // 
            // SpecularCheckBox
            // 
            SpecularCheckBox.AutoSize = true;
            SpecularCheckBox.Checked = true;
            SpecularCheckBox.CheckState = CheckState.Checked;
            SpecularCheckBox.Location = new Point(1027, 787);
            SpecularCheckBox.Name = "SpecularCheckBox";
            SpecularCheckBox.Size = new Size(85, 24);
            SpecularCheckBox.TabIndex = 15;
            SpecularCheckBox.Text = "Enabled";
            SpecularCheckBox.UseVisualStyleBackColor = true;
            SpecularCheckBox.CheckedChanged += SpecularCheckBox_CheckedChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(1403, 30);
            label7.Name = "label7";
            label7.Size = new Size(70, 28);
            label7.TabIndex = 16;
            label7.Text = "Object";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(894, 526);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 20;
            label8.Text = "Strength:";
            // 
            // aStrengthTrackBar
            // 
            aStrengthTrackBar.ImeMode = ImeMode.NoControl;
            aStrengthTrackBar.Location = new Point(958, 517);
            aStrengthTrackBar.Maximum = 100;
            aStrengthTrackBar.Name = "aStrengthTrackBar";
            aStrengthTrackBar.Size = new Size(264, 56);
            aStrengthTrackBar.TabIndex = 19;
            aStrengthTrackBar.TickFrequency = 10;
            aStrengthTrackBar.TickStyle = TickStyle.TopLeft;
            aStrengthTrackBar.Value = 10;
            aStrengthTrackBar.ValueChanged += aStrengthTrackBar_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(894, 674);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 22;
            label9.Text = "Strength:";
            // 
            // dStrengthTrackBar
            // 
            dStrengthTrackBar.ImeMode = ImeMode.NoControl;
            dStrengthTrackBar.Location = new Point(958, 665);
            dStrengthTrackBar.Maximum = 100;
            dStrengthTrackBar.Name = "dStrengthTrackBar";
            dStrengthTrackBar.Size = new Size(264, 56);
            dStrengthTrackBar.TabIndex = 21;
            dStrengthTrackBar.TickFrequency = 10;
            dStrengthTrackBar.TickStyle = TickStyle.TopLeft;
            dStrengthTrackBar.Value = 50;
            dStrengthTrackBar.ValueChanged += dStrengthTrackBar_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(894, 826);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 24;
            label10.Text = "Strength:";
            // 
            // sStrengthTrackBar
            // 
            sStrengthTrackBar.ImeMode = ImeMode.NoControl;
            sStrengthTrackBar.Location = new Point(958, 817);
            sStrengthTrackBar.Maximum = 100;
            sStrengthTrackBar.Name = "sStrengthTrackBar";
            sStrengthTrackBar.Size = new Size(264, 56);
            sStrengthTrackBar.TabIndex = 23;
            sStrengthTrackBar.TickFrequency = 10;
            sStrengthTrackBar.TickStyle = TickStyle.TopLeft;
            sStrengthTrackBar.Value = 50;
            sStrengthTrackBar.ValueChanged += sStrengthTrackBar_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1260, 130);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 26;
            label11.Text = "Shininess:";
            // 
            // ShininessTrackBar
            // 
            ShininessTrackBar.ImeMode = ImeMode.NoControl;
            ShininessTrackBar.Location = new Point(1328, 121);
            ShininessTrackBar.Maximum = 256;
            ShininessTrackBar.Minimum = 1;
            ShininessTrackBar.Name = "ShininessTrackBar";
            ShininessTrackBar.Size = new Size(264, 56);
            ShininessTrackBar.TabIndex = 25;
            ShininessTrackBar.TickFrequency = 20;
            ShininessTrackBar.TickStyle = TickStyle.TopLeft;
            ShininessTrackBar.Value = 64;
            ShininessTrackBar.ValueChanged += ShininessTrackBar_ValueChanged;
            // 
            // lightColorButton
            // 
            lightColorButton.BackColor = Color.White;
            lightColorButton.FlatStyle = FlatStyle.Flat;
            lightColorButton.ImeMode = ImeMode.NoControl;
            lightColorButton.Location = new Point(958, 233);
            lightColorButton.Name = "lightColorButton";
            lightColorButton.Size = new Size(264, 29);
            lightColorButton.TabIndex = 27;
            lightColorButton.UseVisualStyleBackColor = false;
            lightColorButton.Click += lightColorButton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(897, 237);
            label12.Name = "label12";
            label12.Size = new Size(48, 20);
            label12.TabIndex = 28;
            label12.Text = "Color:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1267, 237);
            label13.Name = "label13";
            label13.Size = new Size(48, 20);
            label13.TabIndex = 30;
            label13.Text = "Color:";
            // 
            // objColorButton
            // 
            objColorButton.BackColor = Color.Magenta;
            objColorButton.FlatStyle = FlatStyle.Flat;
            objColorButton.ImeMode = ImeMode.NoControl;
            objColorButton.Location = new Point(1328, 233);
            objColorButton.Name = "objColorButton";
            objColorButton.Size = new Size(264, 29);
            objColorButton.TabIndex = 29;
            objColorButton.UseVisualStyleBackColor = false;
            objColorButton.Click += objColorButton_Click;
            // 
            // AnimationCheckBox
            // 
            AnimationCheckBox.AutoSize = true;
            AnimationCheckBox.Location = new Point(1381, 489);
            AnimationCheckBox.Name = "AnimationCheckBox";
            AnimationCheckBox.Size = new Size(100, 24);
            AnimationCheckBox.TabIndex = 31;
            AnimationCheckBox.Text = "Animation";
            AnimationCheckBox.UseVisualStyleBackColor = true;
            AnimationCheckBox.CheckedChanged += AnimationCheckBox_CheckedChanged;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top;
            label14.AutoSize = true;
            label14.ImeMode = ImeMode.NoControl;
            label14.Location = new Point(1269, 79);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 33;
            label14.Text = "Type";
            // 
            // typeBox
            // 
            typeBox.Anchor = AnchorStyles.Top;
            typeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBox.FormattingEnabled = true;
            typeBox.Location = new Point(1328, 76);
            typeBox.Name = "typeBox";
            typeBox.Size = new Size(266, 28);
            typeBox.TabIndex = 32;
            typeBox.SelectedIndexChanged += typeBox_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top;
            label15.AutoSize = true;
            label15.ImeMode = ImeMode.NoControl;
            label15.Location = new Point(899, 79);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 35;
            label15.Text = "Type";
            // 
            // lightTypeBox
            // 
            lightTypeBox.Anchor = AnchorStyles.Top;
            lightTypeBox.DropDownStyle = ComboBoxStyle.DropDownList;
            lightTypeBox.FormattingEnabled = true;
            lightTypeBox.Location = new Point(958, 76);
            lightTypeBox.Name = "lightTypeBox";
            lightTypeBox.Size = new Size(266, 28);
            lightTypeBox.TabIndex = 34;
            lightTypeBox.SelectedIndexChanged += lightTypeBox_SelectedIndexChanged;
            // 
            // gridCheckBox
            // 
            gridCheckBox.AutoSize = true;
            gridCheckBox.Checked = true;
            gridCheckBox.CheckState = CheckState.Checked;
            gridCheckBox.Location = new Point(1381, 539);
            gridCheckBox.Name = "gridCheckBox";
            gridCheckBox.Size = new Size(59, 24);
            gridCheckBox.TabIndex = 36;
            gridCheckBox.Text = "Grid";
            gridCheckBox.UseVisualStyleBackColor = true;
            gridCheckBox.CheckedChanged += gridCheckBox_CheckedChanged;
            // 
            // axesCheckBox
            // 
            axesCheckBox.AutoSize = true;
            axesCheckBox.Location = new Point(1381, 583);
            axesCheckBox.Name = "axesCheckBox";
            axesCheckBox.Size = new Size(62, 24);
            axesCheckBox.TabIndex = 37;
            axesCheckBox.Text = "Axes";
            axesCheckBox.UseVisualStyleBackColor = true;
            axesCheckBox.CheckedChanged += axesCheckBox_CheckedChanged;
            // 
            // structureCheckBox
            // 
            structureCheckBox.AutoSize = true;
            structureCheckBox.Location = new Point(1381, 635);
            structureCheckBox.Name = "structureCheckBox";
            structureCheckBox.Size = new Size(90, 24);
            structureCheckBox.TabIndex = 38;
            structureCheckBox.Text = "Structure";
            structureCheckBox.UseVisualStyleBackColor = true;
            structureCheckBox.CheckedChanged += structureCheckBox_CheckedChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(1403, 437);
            label16.Name = "label16";
            label16.Size = new Size(62, 28);
            label16.TabIndex = 39;
            label16.Text = "Other";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1262, 184);
            label17.Name = "label17";
            label17.Size = new Size(61, 20);
            label17.TabIndex = 41;
            label17.Text = "Density:";
            // 
            // densityTrackBar
            // 
            densityTrackBar.ImeMode = ImeMode.NoControl;
            densityTrackBar.Location = new Point(1330, 175);
            densityTrackBar.Maximum = 1000;
            densityTrackBar.Minimum = 4;
            densityTrackBar.Name = "densityTrackBar";
            densityTrackBar.Size = new Size(264, 56);
            densityTrackBar.TabIndex = 40;
            densityTrackBar.TickFrequency = 50;
            densityTrackBar.TickStyle = TickStyle.TopLeft;
            densityTrackBar.Value = 300;
            densityTrackBar.ValueChanged += densityTrackBar_ValueChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1276, 674);
            label18.Name = "label18";
            label18.Size = new Size(39, 20);
            label18.TabIndex = 43;
            label18.Text = "FOV:";
            // 
            // fovTrackBar
            // 
            fovTrackBar.ImeMode = ImeMode.NoControl;
            fovTrackBar.Location = new Point(1312, 665);
            fovTrackBar.Maximum = 360;
            fovTrackBar.Name = "fovTrackBar";
            fovTrackBar.Size = new Size(264, 56);
            fovTrackBar.TabIndex = 42;
            fovTrackBar.TickFrequency = 30;
            fovTrackBar.TickStyle = TickStyle.TopLeft;
            fovTrackBar.Value = 60;
            fovTrackBar.ValueChanged += fovTrackBar_ValueChanged;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1635, 905);
            Controls.Add(label18);
            Controls.Add(fovTrackBar);
            Controls.Add(label17);
            Controls.Add(densityTrackBar);
            Controls.Add(label16);
            Controls.Add(structureCheckBox);
            Controls.Add(axesCheckBox);
            Controls.Add(gridCheckBox);
            Controls.Add(label15);
            Controls.Add(lightTypeBox);
            Controls.Add(label14);
            Controls.Add(typeBox);
            Controls.Add(AnimationCheckBox);
            Controls.Add(label13);
            Controls.Add(objColorButton);
            Controls.Add(label12);
            Controls.Add(lightColorButton);
            Controls.Add(label11);
            Controls.Add(ShininessTrackBar);
            Controls.Add(label10);
            Controls.Add(sStrengthTrackBar);
            Controls.Add(label9);
            Controls.Add(dStrengthTrackBar);
            Controls.Add(label8);
            Controls.Add(aStrengthTrackBar);
            Controls.Add(label7);
            Controls.Add(SpecularCheckBox);
            Controls.Add(DiffuseCheckBox);
            Controls.Add(AmbientCheckBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ThetaTrackBar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhiTrackBar);
            Controls.Add(openglControl);
            Controls.Add(openglControl3D);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cubic Bezier";
            KeyDown += Form_KeyDown;
            KeyUp += Form_KeyUp;
            Resize += Form_Resize;
            ((System.ComponentModel.ISupportInitialize)openglControl3D).EndInit();
            ((System.ComponentModel.ISupportInitialize)openglControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhiTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThetaTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)aStrengthTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dStrengthTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)sStrengthTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ShininessTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)densityTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)fovTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SharpGL.OpenGLControl openglControl3D;
        private SharpGL.OpenGLControl openglControl;
        private TrackBar PhiTrackBar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar ThetaTrackBar;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox AmbientCheckBox;
        private CheckBox DiffuseCheckBox;
        private CheckBox SpecularCheckBox;
        private Label label7;
        private Label label8;
        private TrackBar aStrengthTrackBar;
        private Label label9;
        private TrackBar dStrengthTrackBar;
        private Label label10;
        private TrackBar sStrengthTrackBar;
        private Label label11;
        private TrackBar ShininessTrackBar;
        private Button lightColorButton;
        private Label label12;
        private Label label13;
        private Button objColorButton;
        private CheckBox AnimationCheckBox;
        private ColorDialog lightColorDialog;
        private ColorDialog objColorDialog;
        private Label label14;
        private ComboBox typeBox;
        private Label label15;
        private ComboBox lightTypeBox;
        private CheckBox gridCheckBox;
        private CheckBox axesCheckBox;
        private CheckBox structureCheckBox;
        private Label label16;
        private Label label17;
        private TrackBar densityTrackBar;
        private Label label18;
        private TrackBar fovTrackBar;
    }
}