using SharpGL;

namespace Cubic_Bezier {
    public partial class Form : System.Windows.Forms.Form {
        private OpenGL gl;
        private const float pSize = 12;
        private const float lSize = 3;
        private double[] P0 = { 0.15, 0.9 };
        private double[] P1 = { 0.3, 0.1 };
        private double[] P2 = { 0.45, 0.9 };
        private double[] P3 = { 0, 0 };
        private double[] P4 = { 0.6, 0.1 };
        private double[] P5 = { 0.75, 0.9 };
        private double[] P6 = { 0.9, 0.1 };
        private double[][] P;
        private double[,] colors = {
            { 0.8, 0, 0 },
            { 0, 0.8, 0 },
            { 0, 0, 0.8 },
            { 0.8, 0.8, 0 },
            { 0.8, 0, 0.8 },
            { 0, 0.8, 0.8 },
            { 0.5, 0.5, 0.5 },
        };
        private bool[] move = { false, false, false, false, false, false, false };
        private double midPointAspect = 0.5;

        public Form() {
            InitializeComponent();

            gl = openglControl.OpenGL;
            gl.ClearColor(1, 1, 1, 1);
            configProjection();

            P = new[] { P0, P1, P2, P3, P4, P5, P6 };
            placeMiddlePoint();
        }

        private void Form_Resize(object sender, EventArgs e) {
            configProjection();
        }

        private void configProjection() {
            gl.MatrixMode(SharpGL.Enumerations.MatrixMode.Projection);
            gl.LoadIdentity();
            gl.Ortho2D(0, 1, 1, 0);
        }

        private bool isInPoint(double x, double y, double[] p) {
            double w = (double)pSize / openglControl.Width / 2;
            double h = (double)pSize / openglControl.Height / 2;
            return p[0] >= x - w && p[0] <= x + w && p[1] >= y - h && p[1] <= y + h;
        }

        private void placeMiddlePoint() {
            for (byte i = 0; i <= 1; i++) {
                P[3][i] = P[2][i] + (P[4][i] - P[2][i]) * midPointAspect;
            }
        }

        private void dragMiddlePoint(double x, double y) {
            double dx = P[4][0] - P[2][0];
            double dy = P[4][1] - P[2][1];
            double angle = Math.Abs(Math.Atan2(dy, dx));
            if (angle <= Math.PI / 4 || angle >= 3 * Math.PI / 4) midPointAspect = (x - P[2][0]) / dx;
            else midPointAspect = (y - P[2][1]) / dy;
            midPointAspect = Math.Min(midPointAspect, 1);
            midPointAspect = Math.Max(midPointAspect, 0);
            placeMiddlePoint();
        }

        private void openglControl_MouseDown(object sender, MouseEventArgs e) {
            double x = (double)e.X / openglControl.Width;
            double y = (double)e.Y / openglControl.Height;

            for (int i = 0; i < P.Length; i++) {
                if (isInPoint(x, y, P[i])) {
                    if (i == 2 && isInPoint(x, y, P[3])) move[3] = true;
                    else move[i] = true;
                    break;
                }
            }
        }

        private void openglControl_MouseMove(object sender, MouseEventArgs e) {
            double[] coords = {
                (double)e.X / openglControl.Width,
                (double)e.Y / openglControl.Height
            };

            for (int i = 0; i < P.Length; i++) {
                if (move[i]) {
                    if (i == 3) dragMiddlePoint(coords[0], coords[1]);
                    else P[i] = coords;
                    break;
                }
            }

            if (move[2] || move[4]) placeMiddlePoint();
        }

        private void openglControl_MouseUp(object sender, MouseEventArgs e) {
            move = new[] { false, false, false, false, false, false, false };
        }

        private void drawPoints(uint mode, float size, double r, double g, double b, bool presetColors = false) {
            gl.LineWidth(size);
            gl.PointSize(size);
            gl.Color(r, g, b);
            gl.Begin(mode);
            for (int i = 0; i < P.Length; i++) {
                if (presetColors) gl.Color(colors[i, 0], colors[i, 1], colors[i, 2]);
                if (i == 3) gl.Vertex(P[i]);
                gl.Vertex(P[i]);
            }
            gl.End();
        }

        private void drawSegment(double p_amount, double[] p1, double[] p2, double[] p3, double[] p4) {
            double a0, a1, a2, a3, t;

            gl.Begin(OpenGL.GL_LINE_STRIP);
            for (short i = 0; i <= p_amount; i++) {
                t = i / p_amount;
                a0 = (1 - t) * (1 - t) * (1 - t);
                a1 = 3 * (1 - t) * (1 - t) * t;
                a2 = 3 * (1 - t) * t * t;
                a3 = t * t * t;

                gl.Vertex(
                    a0 * p1[0] + a1 * p2[0] + a2 * p3[0] + a3 * p4[0],
                    a0 * p1[1] + a1 * p2[1] + a2 * p3[1] + a3 * p4[1]
                );
            }
            gl.End();
        }

        private void drawBezier(short p_amount, float size, double r, double g, double b) {
            gl.LineWidth(size);
            gl.Color(r, g, b);
            drawSegment(p_amount, P[0], P[1], P[2], P[3]);
            drawSegment(p_amount, P[3], P[4], P[5], P[6]);
        }

        private void openglControl_OpenGLDraw(object sender, SharpGL.RenderEventArgs args) {
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            drawBezier(200, lSize, 0, 0, 0);                            // Bezier Curve
            drawPoints(OpenGL.GL_LINES, 1, 0, 0, 0);                    // Tangents
            drawPoints(OpenGL.GL_POINTS, pSize, 0, 0, 0);               // Points (borders)
            drawPoints(OpenGL.GL_POINTS, pSize - 2, 0, 0, 0, true);     // Points
        }
    }
}