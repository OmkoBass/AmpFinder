using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmpFinder
{
    public partial class window : Form
    {
        List<Element> Elements = new List<Element>(); //List of all components
        Element selected = null;    //Need this to move an element
        bool moving = false;    //Need this to see if it's moving for moving logic

        //For better naming
        int ResistorCounter = 1;
        int CapacitorCounter = 1;
        int AmpGeneratorCounter = 1;
        int VoltGeneratorCounter = 1;


        public window()
        {
            InitializeComponent();

            DrawTimer.Start();
            this.SetStyle(ControlStyles.UserPaint |
              ControlStyles.AllPaintingInWmPaint |
              ControlStyles.ResizeRedraw |
              ControlStyles.ContainerControl |
              ControlStyles.OptimizedDoubleBuffer |
              ControlStyles.SupportsTransparentBackColor
              , true);
            this.DoubleBuffered = true;

            btnRotate.BackgroundImageLayout = ImageLayout.Stretch;
            btnAmpGenerator.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private Element IsSomethingThere(Point P)
        {
            foreach (Element element in Elements)
            {
                if (element.Coordinates.X < P.X && element.Coordinates.X + element.Size.Width > P.X)
                {
                    if (element.Coordinates.X < P.X + element.Size.Width && element.Coordinates.X + element.Size.Width < P.X + element.Size.Width)
                    {
                        if (element.Coordinates.Y < P.Y && element.Coordinates.Y + element.Size.Height > P.Y)
                        {
                            if (element.Coordinates.Y < P.Y + element.Size.Height && element.Coordinates.Y + element.Size.Height < P.Y + element.Size.Height)
                            {
                                return element;
                            }
                        }
                    }
                }
            }
            return null;
        }

        public void DrawGrid()
        {
            int i;
            Pen pen = new Pen(Color.Gray, 1);
            Bitmap bm = new Bitmap(CircuitDraw.Width, CircuitDraw.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                for (i = 0; i < this.Width; i += 20)
                {
                    g.DrawLine(pen, i, 0, i, this.Height);
                    g.DrawLine(pen, 0, i, this.Width, i);
                }
            }
            CircuitDraw.Image = bm;
            CircuitDraw.Refresh();
        }

        private void ClearGrid()
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }

        private void Reset()
        {
            using(Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
                Elements.Clear();
            }
        }
        
        private void DrawElements(List<Element> list)
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
                foreach (Element element in list)
                {
                    element.Draw(g);
                }
        }

        private void DrawShadow(Point point)
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                if (btnResistor.Focused == true)
                {
                    Element element = new Element();
                    element.Coordinates = new Point(point.X - (48 / 2), point.Y - (24 / 2));
                    element.DummyDraw(g);
                }
                else if(btnCapacitor.Focused == true)
                {
                    Element element = new Element();
                    element.Type = Type.Capacitor;
                    element.Coordinates = new Point(point.X - (48 / 2), point.Y - (48 / 2));

                    element.DummyDraw(g);
                }
                else if(btnAmpGenerator.Focused == true)
                {
                    Element element = new Element();
                    element.Type = Type.AmpGenerator;
                    element.Coordinates = new Point(point.X - (52 / 2), point.Y - (52 / 2));

                    element.DummyDraw(g);
                }
                else if(btnVoltGenerator.Focused == true)
                {
                    Element element = new Element();
                    element.Type = Type.VoltGenerator;
                    element.Coordinates = new Point(point.X - (52 / 2), point.Y - (52 / 2));

                    element.DummyDraw(g);
                }
            }
        }

        private void CircuitDraw_MouseClick(object sender, MouseEventArgs e)
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                if (IsSomethingThere(new Point(e.X, e.Y)) != null && !btnCursor.Focused && !btnRotate.Focused)
                {
                    MessageBox.Show("There's already something there.");
                }
                else
                {
                    //I use point center to center my element, looks better, will be usefull
                    if (btnResistor.Focused == true)
                    {
                        Point Center = new Point(e.Location.X - (48 / 2), e.Location.Y - (24 / 2));
                        Element R = new Element(Type.Resistor, $"R{ResistorCounter++}", 50, Orientation.Horizontal, Direction.None, Center);
                        Elements.Add(R);  //Adds the component to global list
                    }
                    else if (btnCapacitor.Focused == true)
                    {
                        Point Center = new Point(e.Location.X - (48 / 2), e.Location.Y - (48 / 2));
                        Element C = new Element(Type.Capacitor, $"C{CapacitorCounter++}", 50, Orientation.Horizontal, Direction.None, Center);
                        Elements.Add(C);
                    }
                    else if (btnAmpGenerator.Focused == true)
                    {
                        Point Center = new Point(e.Location.X - (52 / 2), e.Location.Y - (52 / 2));
                        Element A = new Element(Type.AmpGenerator, $"J{AmpGeneratorCounter++}", 50, Orientation.Horizontal, Direction.Right, Center);
                        Elements.Add(A);
                    }
                    else if (btnVoltGenerator.Focused == true)
                    {
                        Point Center = new Point(e.Location.X - (52 / 2), e.Location.Y - (52 / 2));
                        Element V = new Element(Type.VoltGenerator, $"E{VoltGeneratorCounter++}", 50, Orientation.Horizontal, Direction.Right, Center);
                        Elements.Add(V);
                    }
                    else if (btnCursor.Focused)
                    {
                        BtnCursor_Click(sender, e);
                    }
                    else if (btnRotate.Focused)
                    {
                        BtnRotate_Click(sender, e);
                    }
                }
            }
        }

        private void CircuitDraw_MouseMove(object sender, MouseEventArgs e)
        {
            if(moving == true && selected != null)
            {
                switch (selected.Type)
                {
                    case Type.Resistor:
                        selected.Coordinates = new Point(e.X - (48 / 2), e.Y - (24 / 2));
                        break;
                    case Type.Capacitor:
                        selected.Coordinates = new Point(e.X - (48 / 2), e.Y - (48 / 2));
                        break;
                    case Type.VoltGenerator:
                        selected.Coordinates = new Point(e.X - (52 / 2), e.Y - (52 / 2));
                        break;
                    case Type.AmpGenerator:
                        selected.Coordinates = new Point(e.X - (52 / 2), e.Y - (52 / 2));
                        break;
                }
            }
        }

        private void ProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            Element element = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
            if(element != null)
            {
                if (element.Type == Type.Resistor || element.Type == Type.Capacitor)
                    element.SwitchOrientation();
                else
                    element.SwitchDirection();
            }
        }

        private void BtnCursor_Click(object sender, EventArgs e)
        {
            selected = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
            if(selected != null)
            {
                MouseEventArgs m = e as MouseEventArgs;
                if(m.Button == MouseButtons.Left)
                {
                    lblName.Text = selected.Name;
                    lblValue.Text = selected.Value.ToString();
                    moving = false;
                }
                else if(m.Button == MouseButtons.Right)
                {
                    if (moving == false)
                        moving = true;
                    else 
                        moving = false;
                }
            }
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            ClearGrid();
            DrawGrid();
            DrawElements(Elements);
            DrawShadow(CircuitDraw.PointToClient(Cursor.Position));

            Invalidate();
        }
    }
}
