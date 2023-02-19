using System;
using System.Drawing;
using System.Windows.Forms;
using SharpGL;

namespace ComputerGraphics {
    public partial class MainForm : Form {
        private OpenGL gl;
        private Random rnd = new Random();
        private byte modelType = 2;
        private float[,] points = {
            { 3, 1, 0 },
            { 2, 3, -4 },
            { -3, 4, -6 },
            { -4, 1, -8 },
            { -2, -2, -8 },
            { -1, -3, -6 },
            { 1, -3, -4 },
            { 3, -1, 0 },
        };
        private float[] rotation = { 0, 0, 0 };
        private float[] translation = { 0, 0, 0 };
        private double[] color = { 1, 1, 1 };
        private double[,] rndColors;
        private Boolean colorsAreRandom = true;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            gl = openGLPanel.OpenGL;
            typeBox.SelectedIndex = 2;

            rndColors = new double[points.GetLength(0), 3];
            randomizeColors();
        }

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e) {
            modelType = (byte)typeBox.SelectedIndex;
        }

        private void OpenGLPanel_OpenGLDraw(object sender, RenderEventArgs args) {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();

            gl.Translate(translation[0], translation[1], translation[2]-10);
            gl.Rotate(rotation[0], rotation[1], rotation[2]);

            gl.Begin(modelType);
            gl.Color(color);
            for (int i = 0; i < points.GetLength(0); i++) {
                if(colorsAreRandom) gl.Color(rndColors[i, 0], rndColors[i, 1], rndColors[i, 2]); 
                gl.Vertex(points[i, 0], points[i, 1], points[i, 2]);
            }
            gl.End();
        }

        private void colorButton_Click(object sender, EventArgs e) {
            if (colorDialog.ShowDialog() == DialogResult.OK) {
                Color dColor = colorDialog.Color;
                colorButton.BackColor = dColor;
                color[0] = (double) dColor.R / 255;
                color[1] = (double) dColor.G / 255;
                color[2] = (double) dColor.B / 255;
                colorsAreRandom = false;
            }
        }

        private void rndColorButton_Click(object sender, EventArgs e) {
            randomizeColors();
            colorsAreRandom = true;
            colorButton.BackColor = Color.White;
        }

        private void randomizeColors() {
            for (int i = 0; i < rndColors.GetLength(0); i++) {
                rndColors[i, 0] = rnd.NextDouble();
                rndColors[i, 1] = rnd.NextDouble();
                rndColors[i, 2] = rnd.NextDouble();
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
    }
}
