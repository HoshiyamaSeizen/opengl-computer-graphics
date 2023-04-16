using SharpGL;
using SharpGL.SceneGraph;
using SharpGL.SceneGraph.Quadrics;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Cubic_Bezier {
    public partial class Form : System.Windows.Forms.Form {
        private OpenGL gl2D;
        private OpenGL gl;
        private PeriodicTimer timer;
        private uint shaderProgram;
        private uint[] buffers;
        private const float modelOffset = -4f;
        private const float cubeSize = 0.7f;
        private const float pSize = 16;
        private const float lSize = 3;
        private double[] P0 = { -0.8, -0.7, 0 };
        private double[] P1 = { -0.5, 0.7, 0 };
        private double[] P2 = { -0.2, -0.7, 0 };
        private double[] P3 = { 0, 0, 0 };
        private double[] P4 = { 0.2, 0.7, 0 };
        private double[] P5 = { 0.5, -0.7, 0 };
        private double[] P6 = { 0.8, 0.7, 0 };
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
        private float t = 0;
        private double midPointAspect = 0.5;
        private bool[] move = { false, false, false, false, false, false, false };
        private float[] angle = { 0, 0, 0 };
        private float[] viewPos = { 0, 0, 0 };
        private float[] lightColor = { 1f, 1f, 1f };
        private float[] lightProps = { 0, float.Pi / 2, 2 };
        private float[] lightPos = { 0, 0, 0 };
        private int[] lighting = { 1, 1, 1 };
        private float[] strength = { 0.1f, 0.5f, 0.5f };
        private float[] objColor = { 1f, 0, 1f };
        private float shininess = 64;
        private bool animation = false;
        private bool fullscreen = false;
        private double[] eye = { 0, 0, 0 };
        private double[] center = { 0, 0, 0 };
        private double[] viewAngle = { 0, 0 };
        private bool[] movement = { false, false, false, false, false, false };
        private bool sprint = false;
        private bool crouch = false;
        private bool jumped = false;
        private bool inAir = false;
        private Type selectedType;
        private LightType selectedLightType;
        private bool grid = true;
        private bool axes = false;
        private bool structure = false;
        private int density = 500;
        private float scale = 1;
        private float[] shift = { 0, 0, 0 };
        private bool justSwitched = false;
        private double fov = 60;

        private enum Type { Cube, CubicBezier, Torus, Figure4, Cylinder, Figure6, Figure7 };
        private enum LightType { Point, Spot, Directed };

        Dictionary<string, int> glslVars;

        public Form() {
            InitializeComponent();

            gl2D = openglControl.OpenGL;
            gl2D.ClearColor(1, 1, 1, 1);
            configProjection();

            gl = openglControl3D.OpenGL;
            gl.ClearColor(0.1f, 0.1f, 0.1f, 1);
            configProjection3D();

            P = new[] { P0, P1, P2, P3, P4, P5, P6 };
            placeMiddlePoint();
            calcLightPos(lightProps[0], lightProps[1], lightProps[2]);

            timer = new PeriodicTimer(TimeSpan.FromMilliseconds(20));
            timedFunction();

            uint vertexShader = compileShader("../../../shader.vert", OpenGL.GL_VERTEX_SHADER);
            uint fragmentShader = compileShader("../../../shader.frag", OpenGL.GL_FRAGMENT_SHADER);

            shaderProgram = gl.CreateProgram();
            gl.AttachShader(shaderProgram, vertexShader);
            gl.AttachShader(shaderProgram, fragmentShader);
            gl.BindAttribLocation(shaderProgram, 0, "position");
            gl.BindAttribLocation(shaderProgram, 3, "normVector");
            gl.LinkProgram(shaderProgram);

            glslVars = new Dictionary<string, int>();
            glslVars["t"] = gl.GetUniformLocation(shaderProgram, "t");
            glslVars["lightColor"] = gl.GetUniformLocation(shaderProgram, "lightColor");
            glslVars["lightPos"] = gl.GetUniformLocation(shaderProgram, "lightPos");
            glslVars["viewPos"] = gl.GetUniformLocation(shaderProgram, "viewPos");
            glslVars["isAmbient"] = gl.GetUniformLocation(shaderProgram, "isAmbient");
            glslVars["isDiffuse"] = gl.GetUniformLocation(shaderProgram, "isDiffuse");
            glslVars["isSpecular"] = gl.GetUniformLocation(shaderProgram, "isSpecular");
            glslVars["lookAtMatrix"] = gl.GetUniformLocation(shaderProgram, "lookAtMatrix");
            glslVars["ambientStrength"] = gl.GetUniformLocation(shaderProgram, "ambientStrength");
            glslVars["diffuseStrength"] = gl.GetUniformLocation(shaderProgram, "diffuseStrength");
            glslVars["specularStrength"] = gl.GetUniformLocation(shaderProgram, "specularStrength");
            glslVars["lightType"] = gl.GetUniformLocation(shaderProgram, "lightType");
            glslVars["shininess"] = gl.GetUniformLocation(shaderProgram, "shininess");
            glslVars["animation"] = gl.GetUniformLocation(shaderProgram, "animation");
            glslVars["position"] = 0;
            glslVars["normVector"] = 3;

            uint[] vao = new uint[1];
            gl.GenVertexArrays(1, vao);
            gl.BindVertexArray(vao[0]);

            buffers = new uint[2];
            gl.GenBuffers(2, buffers);

            typeBox.DataSource = Enum.GetValues(typeof(Type));
            typeBox.SelectedIndex = 0;
            lightTypeBox.DataSource = Enum.GetValues(typeof(LightType));
            lightTypeBox.SelectedIndex = 0;
        }

        private void Form_Resize(object sender, EventArgs e) {
            configProjection();
            configProjection3D();
        }

        private void Form_KeyDown(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.W:
                    if (!fullscreen) angle[0]++;
                    else movement[0] = true;
                    break;
                case Keys.S:
                    if (!fullscreen) angle[0]--;
                    else movement[2] = true;
                    break;
                case Keys.D:
                    if (!fullscreen) angle[1]++;
                    else movement[1] = true;
                    break;
                case Keys.A:
                    if (!fullscreen) angle[1]--;
                    else movement[3] = true;
                    break;
                case Keys.E:
                    if (!fullscreen) angle[2]++;
                    break;
                case Keys.Q:
                    if (!fullscreen) angle[2]--;
                    break;
                case Keys.F:
                    toggleFullScreen();
                    break;
                case Keys.Space:
                    if (!inAir) jumped = true;
                    break;
                case Keys.ShiftKey:
                    crouch = true;
                    break;
                case Keys.ControlKey:
                    sprint = true;
                    break;
                case Keys.Oemplus:
                case Keys.Add:
                    scale = float.Min(scale + 0.1f, 10);
                    break;
                case Keys.OemMinus:
                case Keys.Subtract:
                    scale = float.Max(scale - 0.1f, 0.1f);
                    break;
                case Keys.NumPad8:
                    if (e.Control) shift[1] = float.Min(shift[1] + 0.05f, 10);
                    else shift[2] = float.Min(shift[2] + 0.05f, 10);
                    break;
                case Keys.NumPad2:
                    if (e.Control) shift[1] = float.Max(shift[1] - 0.05f, -10);
                    else shift[2] = float.Max(shift[2] - 0.05f, -10);
                    break;
                case Keys.NumPad6:
                    shift[0] = float.Min(shift[0] + 0.05f, 10);
                    break;
                case Keys.NumPad4:
                    shift[0] = float.Max(shift[0] - 0.05f, -10);
                    break;
            }
        }

        private void Form_KeyUp(object sender, KeyEventArgs e) {
            switch (e.KeyCode) {
                case Keys.W:
                    movement[0] = false;
                    break;
                case Keys.S:
                    movement[2] = false;
                    break;
                case Keys.D:
                    movement[1] = false;
                    break;
                case Keys.A:
                    movement[3] = false;
                    break;
                case Keys.ShiftKey:
                    crouch = false;
                    break;
                case Keys.ControlKey:
                    sprint = false;
                    break;
            }
        }

        private void toggleFullScreen() {
            fullscreen = !fullscreen;
            if (fullscreen) {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
                openglControl3D.Location = new Point(0, 0);
                openglControl3D.Size = Size;
                openglControl3D.BringToFront();
                Cursor.Hide();
                centerCursor();
                justSwitched = true;
            } else {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.FixedSingle;
                openglControl3D.Location = new Point(0, 466);
                openglControl3D.Size = new Size(863, 440);
                Cursor.Show();
            }
        }

        private void centerCursor() {
            Point formLocation = openglControl3D.PointToScreen(Point.Empty);
            Cursor.Position = new Point(formLocation.X + openglControl3D.Size.Width / 2, formLocation.Y + openglControl3D.Size.Height / 2);
        }

        private uint compileShader(string path, uint type) {
            uint shader = gl.CreateShader(type);
            string source = File.ReadAllText(path);
            gl.ShaderSource(shader, source);
            gl.CompileShader(shader);
            return shader;
        }

        private void configProjection() {
            gl2D.MatrixMode(OpenGL.GL_PROJECTION);
            gl2D.LoadIdentity();
            gl2D.Ortho2D(-1, 1, -1, 1);
        }

        private void configProjection3D() {
            gl.Viewport(0, 0, openglControl3D.Width, openglControl3D.Height);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(fov + (sprint?2:0), (float)openglControl3D.Width / openglControl3D.Height, 0.001, 100);
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
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
            double x = 2 * (double)e.X / openglControl.Width - 1;
            double y = 1 - 2 * (double)e.Y / openglControl.Height;

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
                2 * (double)e.X / openglControl.Width - 1,
                1 - 2 * (double)e.Y / openglControl.Height
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
            gl2D.LineWidth(size);
            gl2D.PointSize(size);
            gl2D.Color(r, g, b);
            gl2D.Begin(mode);
            for (int i = 0; i < P.Length; i++) {
                if (presetColors) gl2D.Color(colors[i, 0], colors[i, 1], colors[i, 2]);
                if (i == 3) gl2D.Vertex(P[i]);
                gl2D.Vertex(P[i]);
            }
            gl2D.End();
        }

        private void drawSegment(double p_amount, double[] p1, double[] p2, double[] p3, double[] p4) {
            double a0, a1, a2, a3, t;

            gl2D.Begin(OpenGL.GL_LINE_STRIP);
            for (short i = 0; i <= p_amount; i++) {
                t = i / p_amount;
                a0 = (1 - t) * (1 - t) * (1 - t);
                a1 = 3 * (1 - t) * (1 - t) * t;
                a2 = 3 * (1 - t) * t * t;
                a3 = t * t * t;

                gl2D.Vertex(
                    a0 * p1[0] + a1 * p2[0] + a2 * p3[0] + a3 * p4[0],
                    a0 * p1[1] + a1 * p2[1] + a2 * p3[1] + a3 * p4[1]
                );
            }
            gl2D.End();
        }

        private void drawBezier(short p_amount, float size, double r, double g, double b) {
            gl2D.LineWidth(size);
            gl2D.Color(r, g, b);
            drawSegment(p_amount, P[0], P[1], P[2], P[3]);
            drawSegment(p_amount, P[3], P[4], P[5], P[6]);
        }

        private void openglControl_OpenGLDraw(object sender, SharpGL.RenderEventArgs args) {
            gl2D.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            if (selectedType != Type.CubicBezier) return;

            drawBezier(200, lSize, 0, 0, 0);
            drawPoints(OpenGL.GL_LINES, 1, 0, 0, 0);
            drawPoints(OpenGL.GL_POINTS, pSize, 0, 0, 0);
            drawPoints(OpenGL.GL_POINTS, pSize - 2, 0, 0, 0, true);
        }

        private void drawSegment3D(int p_amount, double[] p1, double[] p2, double[] p3, double[] p4) {
            double a0, a1, a2, a3, t;
            float x, y, x_prev = 0, y_prev = 0;

            float[] vertices = new float[p_amount * 6 + 6];
            float[] normals = new float[p_amount * 6 + 6];

            for (short i = 0; i <= p_amount + 1; i++) {
                t = (double)i / p_amount;
                a0 = (1 - t) * (1 - t) * (1 - t);
                a1 = 3 * (1 - t) * (1 - t) * t;
                a2 = 3 * (1 - t) * t * t;
                a3 = t * t * t;

                x = (float)(a0 * p1[0] + a1 * p2[0] + a2 * p3[0] + a3 * p4[0]);
                y = (float)(a0 * p1[1] + a1 * p2[1] + a2 * p3[1] + a3 * p4[1]);

                if (i > 0) {
                    i--;
                    vertices[i * 6 + 0] = x_prev;
                    vertices[i * 6 + 1] = y_prev;
                    vertices[i * 6 + 2] = -1;
                    vertices[i * 6 + 3] = x_prev;
                    vertices[i * 6 + 4] = y_prev;
                    vertices[i * 6 + 5] = 1;

                    normals[i * 6 + 0] = y_prev - y;
                    normals[i * 6 + 1] = x - x_prev;
                    normals[i * 6 + 2] = 0;
                    normals[i * 6 + 3] = y_prev - y;
                    normals[i * 6 + 4] = x - x_prev;
                    normals[i * 6 + 5] = 0;
                    i++;
                }

                x_prev = x;
                y_prev = y;
            }

            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, buffers[0]);
            gl.BufferData(OpenGL.GL_ARRAY_BUFFER, vertices, OpenGL.GL_STATIC_DRAW);
            gl.VertexAttribPointer(0, 3, OpenGL.GL_FLOAT, false, 0, 0);

            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, buffers[1]);
            gl.BufferData(OpenGL.GL_ARRAY_BUFFER, normals, OpenGL.GL_STATIC_DRAW);
            gl.VertexAttribPointer(3, 3, OpenGL.GL_FLOAT, false, 0, 0);

            gl.DrawArrays(OpenGL.GL_QUAD_STRIP, 0, vertices.Length / 3);
        }

        private void drawBezier3D(short p_amount) {
            drawSegment3D(p_amount, P[0], P[1], P[2], P[3]);
            drawSegment3D(p_amount, P[3], P[4], P[5], P[6]);
        }

        private void drawCube(float s, float[] pos, float[] color) {
            gl.Color(color);
            gl.PushMatrix();
            gl.Translate(pos[0], pos[1], pos[2]);
            float[] vertices = { -s, -s, s, s, -s, s, s, s, s, -s, s, s, -s, -s, -s, -s, s, -s, s, s, -s, s, -s, -s, -s, -s, s, -s, s, s, -s, s, -s, -s, -s, -s, s, -s, -s, s, s, -s, s, s, s, s, -s, s, -s, s, s, s, s, s, s, s, -s, -s, s, -s, -s, -s, s, -s, -s, -s, s, -s, -s, s, -s, s, };
            float[] normals = { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, -1, 0, 0, -1, 0, 0, -1, 0, 0, -1, -1, 0, 0, -1, 0, 0, -1, 0, 0, -1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, -1, 0, 0, -1, 0, 0, -1, 0, 0, -1, 0 };

            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, buffers[0]);
            gl.VertexAttribPointer(0, 3, OpenGL.GL_FLOAT, false, 0, 0);
            gl.BufferData(OpenGL.GL_ARRAY_BUFFER, vertices, OpenGL.GL_STATIC_DRAW);
            gl.DrawArrays(OpenGL.GL_QUADS, 0, vertices.Length / 3);

            gl.BindBuffer(OpenGL.GL_ARRAY_BUFFER, buffers[1]);
            gl.BufferData(OpenGL.GL_ARRAY_BUFFER, normals, OpenGL.GL_STATIC_DRAW);
            gl.VertexAttribPointer(3, 3, OpenGL.GL_FLOAT, false, 0, 0);

            gl.PopMatrix();
        }

        private void calcLightPos(float phi, float theta, float r) {
            lightPos[0] = (float)(r * Math.Sin(theta) * Math.Sin(phi));
            lightPos[1] = (float)(r * Math.Cos(theta));
            lightPos[2] = (float)(r * Math.Sin(theta) * Math.Cos(phi) + modelOffset);
        }

        private void drawGrid() {
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(1f, 1f, 1f);
            for (int i = -100; i < 100; i += 2) {
                gl.Vertex(-100, -2, i);
                gl.Vertex(100, -2, i);
            }
            for (int i = -100; i < 100; i += 2) {
                gl.Vertex(i, -2, -100);
                gl.Vertex(i, -2, 100);
            }
            gl.End();
        }

        private void drawAxes() {
            gl.LineWidth(4f);
            gl.Translate(0, -2, 0);
            gl.Begin(OpenGL.GL_LINES);
            gl.Color(1f, 0f, 0f);
            gl.Vertex(0, 0, 0);
            gl.Vertex(1, 0, 0);
            gl.Color(0f, 1f, 0f);
            gl.Vertex(0, 0, 0);
            gl.Vertex(0, 1, 0);
            gl.Color(0f, 0f, 1f);
            gl.Vertex(0, 0, 0);
            gl.Vertex(0, 0, 1);
            gl.End();
            gl.Translate(0, 2, 0);
            gl.LineWidth(1f);
        }

        private void drawCircle(float r, int density_whole, float[] pos, float[] rot) {
            float angle, x, y;

            gl.PushMatrix();
            gl.Translate(pos[0], pos[1], pos[2]);
            gl.Rotate(rot[0], rot[1], rot[2]);
            gl.Begin(structure ? OpenGL.GL_LINE_STRIP : OpenGL.GL_POLYGON);
            gl.Normal(0f, 0f, 1f);
            for (int i = 0; i <= density_whole; i++) {
                angle = i * 2.0f * float.Pi / density;
                x = -r * float.Cos(angle);
                y = r * float.Sin(angle);

                gl.Vertex(x, y, 0);
                if (structure) {
                    gl.Vertex(0, 0, 0);
                    gl.Vertex(x, y, 0);
                }
            }
            gl.End();
            gl.PopMatrix();
        }

        private void calcCircle(float[] pos, float r, float _1, float _2, int density, float[] vertices, float[] normals) {
            float x, y;
            for (int i = 0; i <= density; i++) {
                x = (float)(r * Math.Cos(i * 2.0f * float.Pi / density));
                y = (float)(r * Math.Sin(i * 2.0f * float.Pi / density));
                vertices[i * 3] = x + pos[0];
                vertices[i * 3 + 1] = y + pos[1];
                vertices[i * 3 + 2] = pos[2];
                normals[i * 3] = x;
                normals[i * 3 + 1] = y;
                normals[i * 3 + 2] = 0;
            }
        }

        private void calcLine(float[] pos, float r1, float r2, float h, int density, float[] vertices, float[] normals) {
            float t;
            float ny = r1 - r2;
            for (int i = 0; i <= density; i++) {
                t = (float)i / density;
                vertices[i * 3] = -r1 + t * (r1 - r2) + pos[0];
                vertices[i * 3 + 1] = pos[1] + h * i / density;
                vertices[i * 3 + 2] = pos[2];

                normals[i * 3] = -h;
                normals[i * 3 + 1] = ny;
                normals[i * 3 + 2] = 0;
            }
        }

        private void calcParabola(float[] pos, float r, float h, float _, int density, float[] vertices, float[] normals) {
            float t, x, y, x_prev = 0, y_prev = 0;
            for (int i = 0; i <= density + 1; i++) {
                t = (float)i / density;
                x = -r * t;
                y = -4 * h * x / r * (x / r + 1);

                if (i > 0) {
                    i--;
                    vertices[i * 3] = x_prev + pos[0];
                    vertices[i * 3 + 1] = y_prev + pos[1];
                    vertices[i * 3 + 2] = pos[2];

                    normals[i * 3] = y - y_prev;
                    normals[i * 3 + 1] = x_prev - x;
                    normals[i * 3 + 2] = 0;
                    i++;
                }

                x_prev = x;
                y_prev = y;
            }
        }

        private void drawRotated(int density_whole, int density_part, float[] pos, float p1, float p2, float p3, 
                                            Action<float[], float, float, float, int, float[], float[]> calcPart) {
            int density = density_part;
            float[] vertices = new float[(density + 1) * 3];
            float[] normals = new float[(density + 1) * 3];
            float cos, sin, x, y, z, nx, ny, nz;
            float angle = 2 * float.Pi / density_whole;

            calcPart(pos, p1, p2, p3, density, vertices, normals);
            for (int i = 0; i <= density_whole; i++) {
                cos = float.Cos(angle);
                sin = float.Sin(angle);

                gl.Begin(structure ? OpenGL.GL_LINE_STRIP : OpenGL.GL_QUAD_STRIP);
                for (int j = 0; j <= density; j++) {
                    x = vertices[j * 3];
                    y = vertices[j * 3 + 1];
                    z = vertices[j * 3 + 2];

                    nx = normals[j * 3];
                    ny = normals[j * 3 + 1];
                    nz = normals[j * 3 + 2];

                    normals[j * 3] = nx * cos - nz * sin;
                    normals[j * 3 + 1] = ny;
                    normals[j * 3 + 2] = nx * sin + nz * cos;

                    gl.Normal((nx + normals[j * 3]) / 2, (ny + normals[j * 3 + 1]) / 2, (nz + normals[j * 3 + 2]) / 2);

                    gl.Vertex(x, y, z);

                    vertices[j * 3] = x * cos - z * sin;
                    vertices[j * 3 + 1] = y;
                    vertices[j * 3 + 2] = x * sin + z * cos;

                    gl.Vertex(vertices[j * 3], vertices[j * 3 + 1], vertices[j * 3 + 2]);
                    if (structure) gl.Vertex(x, y, z);
                }
                gl.End();
            }
        }

        private void drawTorus(int density_whole, int density_part) {
            drawRotated(density_whole, density_part, new float[] { -1, -1, 0 }, 0.4f, 0, 0, calcCircle);
        }

        private void drawFigure4(int density_whole, int density_part) {
            drawRotated(density_whole, density_part, new float[] { 0, -0.5f, 0 }, 0.5f, 0.7f, 0.2f, calcLine);
            drawRotated(density_whole, density_part, new float[] { 0, -0.8f, 0 }, 0.5f, 0.5f, 0.3f, calcLine);
            drawRotated(density_whole, density_part, new float[] { 0, -0.9f, 0 }, 1f, 0.5f, 0.1f, calcLine);
            drawRotated(density_whole, density_part, new float[] { 0, -1f, 0 }, 1.2f, 1f, 0.1f, calcLine);
        }

        private void drawCylinder(int density_whole, int density_part) {
            drawRotated(density_whole, density_part, new float[] { 0, -1.3f, 0 }, 0.5f, 0.5f, 1, calcLine);
            drawCircle(0.5f, density_whole, new float[] { 0, -0.3f, 0 }, new float[] { -90, 0, 0 });
            drawCircle(0.5f, density_whole, new float[] { 0, -1.3f, 0 }, new float[] { 90, 0, 0 });
        }

        private void drawFigure6(int density_whole, int density_part) {
            drawRotated(density_whole, density_part, new float[] { 0, -2.5f, 0 }, 1, 2, 0, calcParabola);
        }

        private void drawFigure7(int density_whole, int density_part) {
            drawRotated(density_whole, density_part, new float[] { 0, 0, 0 }, 0.8f, 0, 0.3f, calcLine);
            drawRotated(density_whole, density_part, new float[] { 0, -0.3f, 0 }, 1f, 0.8f, 0.3f, calcLine);
            drawRotated(density_whole, density_part, new float[] { 0, -0.6f, 0 }, 0.8f, 1f, 0.3f, calcLine);
            drawCircle(0.8f, density_whole, new float[] { 0, -0.6f, 0 }, new float[] { 90, 0, 0 });
        }

        private void openglControl3D_OpenGLDraw(object sender, RenderEventArgs args) {
            configProjection3D();
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
            gl.EnableVertexAttribArray((uint)glslVars["position"]);
            gl.EnableVertexAttribArray((uint)glslVars["normVector"]);

            center[0] = eye[0] + Math.Sin(viewAngle[0]) * Math.Cos(viewAngle[1]);
            center[1] = eye[1] + Math.Sin(viewAngle[1]);
            center[2] = eye[2] - Math.Cos(viewAngle[0]) * Math.Cos(viewAngle[1]);

            gl.LookAt(eye[0], eye[1] + (crouch ? -0.3 : 0), eye[2], center[0], center[1] + (crouch ? -0.3 : 0), center[2], 0, 1, 0);
            Matrix lookAtMatrix = gl.GetModelViewMatrix();

            drawCube(0.02f, lightPos, lightColor);

            gl.Translate(0, 0, modelOffset);

            if (grid) drawGrid();
            if (axes) drawAxes();

            gl.Rotate(angle[0], angle[1], angle[2]);
            gl.Scale(scale, scale, scale);
            gl.Translate(shift[0], shift[1], shift[2]);

            gl.LineWidth(1);
            gl.Color(objColor);
            gl.UseProgram(shaderProgram);
            gl.Uniform1(glslVars["t"], t);
            gl.UniformMatrix4(glslVars["lookAtMatrix"], 1, false, lookAtMatrix.AsRowMajorArrayFloat);
            gl.Uniform3(glslVars["lightColor"], 1, lightColor);
            gl.Uniform3(glslVars["lightPos"], 1, lightPos);
            gl.Uniform3(glslVars["viewPos"], (float)eye[0], (float)eye[1], (float)eye[2]);
            gl.Uniform1(glslVars["isAmbient"], lighting[0]);
            gl.Uniform1(glslVars["isDiffuse"], lighting[1]);
            gl.Uniform1(glslVars["isSpecular"], lighting[2]);
            gl.Uniform1(glslVars["ambientStrength"], strength[0]);
            gl.Uniform1(glslVars["diffuseStrength"], strength[1]);
            gl.Uniform1(glslVars["specularStrength"], strength[2]);
            gl.Uniform1(glslVars["shininess"], shininess);
            gl.Uniform1(glslVars["animation"], animation ? 1 : 0);
            gl.Uniform1(glslVars["lightType"], (float)selectedLightType);

            switch (selectedType) {
                case Type.Cube:
                    drawCube(cubeSize, viewPos, objColor);
                    break;
                case Type.CubicBezier:
                    drawBezier3D(2500);
                    break;
                case Type.Torus:
                    drawTorus(density, Math.Max(4, Math.Min(100, density / 2)));
                    break;
                case Type.Figure4:
                    drawFigure4(density, structure ? Math.Max(2, Math.Min(100, density / 2)) : 2);
                    break;
                case Type.Cylinder:
                    drawCylinder(density, structure ? Math.Max(2, Math.Min(100, density / 2)) : 2);
                    break;
                case Type.Figure6:
                    drawFigure6(density, Math.Max(4, Math.Min(100, density / 2)));
                    break;
                case Type.Figure7:
                    drawFigure7(density, structure ? Math.Max(2, Math.Min(100, density / 2)) : 2);
                    break;
            }

            gl.UseProgram(0);
            gl.DisableVertexAttribArray((uint)glslVars["position"]);
            gl.DisableVertexAttribArray((uint)glslVars["normVector"]);
        }

        private async void timedFunction() {
            double dx, dz;
            double s = 0.1;
            double[] speed = { 0, 0, 0 };
            while (await timer.WaitForNextTickAsync()) {
                t += 0.1f;

                if (jumped) {
                    jumped = false;
                    inAir = true;
                    speed[1] = 3 * s;
                }

                if (sprint) s *= 3;
                if (crouch) s /= 3;

                dx = Math.Sin(viewAngle[0]);
                dz = -Math.Cos(viewAngle[0]);

                if (movement[1] || movement[3]) {
                    dx /= Math.Sqrt(2);
                    dz /= Math.Sqrt(2);
                };

                if (movement[0]) {
                    eye[0] += dx * s;
                    eye[2] += dz * s;
                }
                if (movement[2]) {
                    eye[0] -= dx * s;
                    eye[2] -= dz * s;
                }

                if (movement[1] || movement[3]) {
                    dx = Math.Sin(viewAngle[0] + Math.PI / 2);
                    dz = -Math.Cos(viewAngle[0] + Math.PI / 2);

                    if (movement[0] || movement[2]) {
                        dx /= Math.Sqrt(2);
                        dz /= Math.Sqrt(2);
                    };

                    if (movement[1]) {
                        eye[0] += dx * s;
                        eye[2] += dz * s;
                    }
                    if (movement[3]) {
                        eye[0] -= dx * s;
                        eye[2] -= dz * s;
                    }
                }

                if (inAir) {
                    speed[1] -= 0.02;
                    eye[1] = Math.Max(eye[1] + speed[1], 0);

                    if (eye[1] == 0) inAir = false;
                }

                if (sprint) s /= 3;
                if (crouch) s *= 3;
            }
        }

        private void PhiTrackBar_ValueChanged(object sender, EventArgs e) {
            lightProps[0] = (float)(PhiTrackBar.Value * Math.PI / 180);
            calcLightPos(lightProps[0], lightProps[1], lightProps[2]);
        }

        private void ThetaTrackBar_ValueChanged(object sender, EventArgs e) {
            lightProps[1] = (float)(ThetaTrackBar.Value * Math.PI / 180);
            calcLightPos(lightProps[0], lightProps[1], lightProps[2]);
        }

        private void AmbientCheckBox_CheckedChanged(object sender, EventArgs e) {
            lighting[0] = AmbientCheckBox.Checked ? 1 : 0;
        }

        private void DiffuseCheckBox_CheckedChanged(object sender, EventArgs e) {
            lighting[1] = DiffuseCheckBox.Checked ? 1 : 0;
        }

        private void SpecularCheckBox_CheckedChanged(object sender, EventArgs e) {
            lighting[2] = SpecularCheckBox.Checked ? 1 : 0;
        }

        private void aStrengthTrackBar_ValueChanged(object sender, EventArgs e) {
            strength[0] = (float)aStrengthTrackBar.Value / 100;
        }

        private void dStrengthTrackBar_ValueChanged(object sender, EventArgs e) {
            strength[1] = (float)dStrengthTrackBar.Value / 100;
        }

        private void sStrengthTrackBar_ValueChanged(object sender, EventArgs e) {
            strength[2] = (float)sStrengthTrackBar.Value / 100;
        }

        private void ShininessTrackBar_ValueChanged(object sender, EventArgs e) {
            shininess = ShininessTrackBar.Value;
        }

        private void AnimationCheckBox_CheckedChanged(object sender, EventArgs e) {
            animation = AnimationCheckBox.Checked;
        }

        private void lightColorButton_Click(object sender, EventArgs e) {
            if (lightColorDialog.ShowDialog() == DialogResult.OK) {
                Color dColor = lightColorDialog.Color;
                lightColorButton.BackColor = dColor;
                lightColor[0] = (float)dColor.R / 255;
                lightColor[1] = (float)dColor.G / 255;
                lightColor[2] = (float)dColor.B / 255;
            }
        }

        private void objColorButton_Click(object sender, EventArgs e) {
            if (objColorDialog.ShowDialog() == DialogResult.OK) {
                Color dColor = objColorDialog.Color;
                objColorButton.BackColor = dColor;
                objColor[0] = dColor.R / 255;
                objColor[1] = dColor.G / 255;
                objColor[2] = dColor.B / 255;
            }
        }

        private void openglControl3D_MouseMove(object sender, MouseEventArgs e) {
            if (justSwitched) {
                justSwitched = false;
                return;
            }
            if (fullscreen) {
                double dx = e.X - openglControl3D.Size.Width / 2;
                double dy = openglControl3D.Size.Height / 2 - e.Y;

                viewAngle[0] += dx / 300;
                viewAngle[1] += dy / 300;

                if (viewAngle[0] > 2 * Math.PI) viewAngle[0] -= 2 * Math.PI;
                if (viewAngle[0] < 0) viewAngle[0] += 2 * Math.PI;
                if (viewAngle[1] > Math.PI / 2) viewAngle[1] = Math.PI / 2;
                if (viewAngle[1] < -Math.PI / 2) viewAngle[1] = -Math.PI / 2;


                centerCursor();
            }
        }

        private void typeBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedType = (Type)typeBox.SelectedItem;
        }

        private void lightTypeBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedLightType = (LightType)lightTypeBox.SelectedItem;
        }

        private void gridCheckBox_CheckedChanged(object sender, EventArgs e) {
            grid = gridCheckBox.Checked;
        }

        private void axesCheckBox_CheckedChanged(object sender, EventArgs e) {
            axes = axesCheckBox.Checked;
        }

        private void structureCheckBox_CheckedChanged(object sender, EventArgs e) {
            structure = structureCheckBox.Checked;
        }

        private void densityTrackBar_ValueChanged(object sender, EventArgs e) {
            density = densityTrackBar.Value;
        }

        private void fovTrackBar_ValueChanged(object sender, EventArgs e) {
            fov = fovTrackBar.Value;
        }
    }
}