using System;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;

namespace ComputerGraphics {
    public partial class MainForm : Form {
        private OpenGL gl;
        private Random rnd = new Random();
        private uint displayList;
        private bool fractalShown = false;
        private byte iterCount = 1;
        private double reductionFactor = 0.3;
        private double fracDensity = 0.1;
        private double fracDensityChange = 0.3;
        private double initCircleFactor = 0.6;
        private double xScaleFactor = 0.3;
        private const byte zOffset = 10;
        private byte modelType = 2;
        private ushort alphaTestType = 7;
        private float alphaRef = 0;
        private ushort sFactor = 1;
        private ushort dFactor = 0;
        private short scissorX = 0;
        private short scissorY = 0;
        private short scissorW = 1000;
        private short scissorH = 1000;
        private float[,] points = {
            { 3, 1, 0 },
            { 2, 3, 0 },
            { -3, 4, 0 },
            { -4, 1, 0 },
            { -2, -2, 0 },
            { -1, -3, 0 },
            { 1, -3, 0 },
            { 3, -1, 0 },
        };
        private float[] rotation = { 0, 0, 0 };
        private float[] translation = { 0, 0, 0 };
        private float scale = 1;
        private float[] camera = { 0, 0, 0 };
        private double[] color = { 1, 1, 1, 1 };
        private double[,] rndColors;
        private Boolean colorsAreRandom = true;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            gl = openGLPanel.OpenGL;
            typeBox.SelectedIndex = 2;
            alphaTestBox.SelectedIndex = 7;
            sFactorBox.SelectedIndex = 1;
            dFactorBox.SelectedIndex = 0;

            gl.Enable(OpenGL.GL_ALPHA_TEST);
            gl.Enable(OpenGL.GL_SCISSOR_TEST);
            gl.Enable(OpenGL.GL_BLEND);

            rndColors = new double[points.GetLength(0), 4];
            randomizeColors();
            resetScissor();

            displayList = gl.GenLists(1);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            resetScissor();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.W:
                    cameraYRange.Value = Math.Min(cameraYRange.Value + (decimal) 0.1, cameraYRange.Maximum);
                    break;
                case Keys.S:
                    cameraYRange.Value = Math.Max(cameraYRange.Value - (decimal) 0.1, cameraYRange.Minimum);
                    break;
                case Keys.D:
                    cameraXRange.Value = Math.Min(cameraXRange.Value + (decimal) 0.1, cameraXRange.Maximum);
                    break;
                case Keys.A:
                    cameraXRange.Value = Math.Max(cameraXRange.Value - (decimal) 0.1, cameraXRange.Minimum);
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    scaleRange.Value = Math.Min(scaleRange.Value + (decimal) 0.1, scaleRange.Maximum);
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    scaleRange.Value = Math.Max(scaleRange.Value - (decimal) 0.1, scaleRange.Minimum);
                    break;
            }
        }

        private void updateFractal() {
            if (fractalShown && iterCount > 3) {
                gl.NewList(displayList, OpenGL.GL_COMPILE);
                buildFractal(iterCount, 0, 0, 3, 0, 1);
                gl.EndList();
            }
        }

        private double calcStep(double progress) {
            return fracDensity * (1 - progress) + fracDensityChange;
        }

        private void buildFractal(int iter, double x, double y, double radius, double angle, double scaleX, double circlePartCoef = 0, double r = 0, double g = 0, double b = 0) {
            gl.PushMatrix();

            // Which part of the circle should be used
            if (circlePartCoef == 0) circlePartCoef = initCircleFactor;
            double circlePart = circlePartCoef * Math.PI * 2;

            // Transorm the current branch of the figure
            gl.Translate(x, y, 0);
            gl.Rotate(angle / Math.PI * 180, 0, 0, 1);
            gl.Scale(scaleX, 1, 1);

            if (iter == 1) {
                // Draw the branch at the final iteration
                gl.Begin(OpenGL.GL_LINE_STRIP);
                for (double i = 0; i <= circlePart; i += calcStep(i / circlePart)) {
                    if (r + g + b == 0) gl.Color(0.2 + 0.8 * (i / circlePart), rndColors[0, 1], rndColors[0, 2]);
                    else gl.Color(r, g, b);
                    gl.Vertex(Math.Sin(-i) * radius, Math.Cos(i) * radius);
                }
                gl.End();
            } else {
                // Else divide branch into symmetrical parts
                double progress = 0;
                for (double i = 0; i <= circlePart; i += calcStep(progress), progress = i / circlePart)
                    buildFractal(
                        iter - 1, // next iteration
                        Math.Sin(-i) * radius, Math.Cos(i) * radius, // relative x, y
                        radius * reductionFactor,  // radius reduction
                        (i - Math.PI) / 2,  // rotate child branch (depends on i)
                        progress + xScaleFactor * (1 - progress), // flatten child branch (depends on i)
                        initCircleFactor * (1 + progress) / 2, // shorten the length of circumference for the child branch (depends on i)
                        rndColors[0, 0] + (1- rndColors[0, 0]) * (i / circlePart), rndColors[0, 1], rndColors[0, 2]
                    );
            }
            gl.PopMatrix();
        }

        private void OpenGLPanel_OpenGLDraw(object sender, RenderEventArgs args) {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.LookAt(camera[0], camera[1], camera[2], camera[0], camera[1], camera[2] - zOffset, 0, 1, 0);

            gl.Translate(translation[0], translation[1], translation[2] - zOffset);
            gl.Rotate(rotation[0], rotation[1], rotation[2]);
            gl.Scale(scale, scale, scale);

            gl.Scissor(scissorX, scissorY, scissorW, scissorH);
            gl.AlphaFunc(alphaTestType, alphaRef);
            gl.BlendFunc(sFactor, dFactor);

            if (fractalShown) {
                if (iterCount > 3) gl.CallList(displayList);
                else buildFractal(iterCount, 0, 0, 3, 0, 1);
            } else {
                gl.Begin(modelType);
                gl.Color(color);
                for (int i = 0; i < points.GetLength(0); i++) {
                    if (colorsAreRandom) gl.Color(rndColors[i, 0], rndColors[i, 1], rndColors[i, 2], rndColors[i, 3]);
                    gl.Vertex(points[i, 0], points[i, 1], points[i, 2]);
                }
                gl.End();
            }
        }

        private void resetScissor() {
            scissorWRange.Maximum = openGLPanel.Width;
            scissorWRange.Value = openGLPanel.Width;
            scissorHRange.Maximum = openGLPanel.Height;
            scissorHRange.Value = openGLPanel.Height;
        }

        private void colorButton_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                Color dColor = colorDialog.Color;
                colorButton.BackColor = dColor;
                color[0] = (double) dColor.R / 255;
                color[1] = (double) dColor.G / 255;
                color[2] = (double) dColor.B / 255;
                color[3] = rnd.NextDouble();
                colorsAreRandom = false;
                updateFractal();
            }
        }

        private void rndColorButton_Click(object sender, EventArgs e) {
            randomizeColors();
            colorsAreRandom = true;
            colorButton.BackColor = Color.White;
            updateFractal();
        }

        private void randomizeColors() {
            for (int i = 0; i < rndColors.GetLength(0); i++) {
                rndColors[i, 0] = rnd.NextDouble();
                rndColors[i, 1] = rnd.NextDouble();
                rndColors[i, 2] = rnd.NextDouble();
                rndColors[i, 3] = rnd.NextDouble();
            }
        }

        private void rotateXRange_ValueChanged(object sender, EventArgs e) {
            rotation[0] = (float) rotateXRange.Value;
        }

        private void rotateYRange_ValueChanged(object sender, EventArgs e) {
            rotation[1] = (float)rotateYRange.Value;
        }

        private void rotateZRange_ValueChanged(object sender, EventArgs e) {
            rotation[2] = (float)rotateZRange.Value;
        }

        private void translateXRange_ValueChanged(object sender, EventArgs e) {
            translation[0] = (float)translateXRange.Value;
        }

        private void translateYRange_ValueChanged(object sender, EventArgs e) {
            translation[1] = (float)translateYRange.Value;
        }

        private void translateZRange_ValueChanged(object sender, EventArgs e) {
            translation[2] = (float)translateZRange.Value;
        }

        private void alphaRefTrackBar_Scroll(object sender, EventArgs e) {
            alphaRef = (float)alphaRefTrackBar.Value / 100;
        }

        private void scissorXRange_ValueChanged(object sender, EventArgs e) {
            scissorX = (short) scissorXRange.Value;
        }

        private void scissorYRange_ValueChanged(object sender, EventArgs e) {
            scissorY = (short)scissorYRange.Value;
        }

        private void scissorWRange_ValueChanged(object sender, EventArgs e) {
            scissorW = (short)scissorWRange.Value;
        }

        private void scissorHRange_ValueChanged(object sender, EventArgs e) {
            scissorH = (short)scissorHRange.Value;
        }

        private void scaleRange_ValueChanged(object sender, EventArgs e) {
            scale = (float)scaleRange.Value;
        }

        private void cameraXRange_ValueChanged(object sender, EventArgs e) {
            camera[0] = (float)cameraXRange.Value;
        }

        private void cameraYRange_ValueChanged(object sender, EventArgs e) {
            camera[1] = (float)cameraYRange.Value;
        }

        private void iterationRange_ValueChanged(object sender, EventArgs e) {
            iterCount = (byte) iterationRange.Value;
            updateFractal();
        }

        private void reductionFactorRange_ValueChanged(object sender, EventArgs e) {
            reductionFactor = (double)reductionFactorRange.Value;
            updateFractal();
        }

        private void circlePartRange_ValueChanged(object sender, EventArgs e) {
            initCircleFactor = (double)circlePartRange.Value;
            updateFractal();
        }

        private void densityRange_ValueChanged(object sender, EventArgs e) {
            fracDensity = (double)densityRange.Value;
            updateFractal();
        }

        private void densityChangeRange_ValueChanged(object sender, EventArgs e) {
            fracDensityChange = (double)densityChangeRange.Value;
            updateFractal();
        }

        private void xScaleFactorRange_ValueChanged(object sender, EventArgs e) {
            xScaleFactor = (double)xScaleFactorRange.Value;
            updateFractal();
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e) {
            modelType = (byte)typeBox.SelectedIndex;
            fractalCheckBox.Checked = false;
        }

        private void alphaTestBox_SelectedIndexChanged(object sender, EventArgs e) {
            alphaTestType = (ushort) (alphaTestBox.SelectedIndex + 512);
        }

        private void sFactorBox_SelectedIndexChanged(object sender, EventArgs e) {
            sFactor = (ushort)sFactorBox.SelectedIndex;
            if (sFactor > 1) sFactor += 768;
        }

        private void dFactorBox_SelectedIndexChanged(object sender, EventArgs e) {
            dFactor = (ushort)dFactorBox.SelectedIndex;
            if (dFactor > 1) dFactor += 766;
        }

        private void fractalCheckBox_CheckedChanged(object sender, EventArgs e) {
            fractalShown = fractalCheckBox.Checked;
            updateFractal();
            
        }
    }
}
