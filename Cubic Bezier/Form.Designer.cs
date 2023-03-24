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
            openglControl = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)openglControl).BeginInit();
            SuspendLayout();
            // 
            // openglControl
            // 
            openglControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            openglControl.DrawFPS = false;
            openglControl.FrameRate = 60;
            openglControl.Location = new Point(0, 0);
            openglControl.Margin = new Padding(4, 5, 4, 5);
            openglControl.Name = "openglControl";
            openglControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            openglControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            openglControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            openglControl.Size = new Size(800, 450);
            openglControl.TabIndex = 0;
            openglControl.OpenGLDraw += openglControl_OpenGLDraw;
            openglControl.MouseDown += openglControl_MouseDown;
            openglControl.MouseMove += openglControl_MouseMove;
            openglControl.MouseUp += openglControl_MouseUp;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openglControl);
            KeyPreview = true;
            Name = "Form";
            ShowIcon = false;
            Text = "Cubic Bezier";
            Resize += Form_Resize;
            ((System.ComponentModel.ISupportInitialize)openglControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SharpGL.OpenGLControl openglControl;
    }
}