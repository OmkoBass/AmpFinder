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
        List<Element> Components = new List<Element>(); //List of all components
        Element selected = null;    //Need this to move an element
        bool moving = false;    //Need this to see if it's moving for moving logic

        Element connectee1 = null;
        Element connectee2 = null;

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

            Image connect = Image.FromFile("Connector.png");
            Image cursor = Image.FromFile("Cursor.png");
            Image rotate = Image.FromFile("Rotate.png");
            btnConnect.Image = connect; btnCursor.Image = cursor;
            btnRotate.BackgroundImage = rotate; btnRotate.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void ResistorToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(ResistorToggle.Checked == true)
            {
                SetAllFalse(0);
            }
        }

        private void CapacitorToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(CapacitorToggle.Checked == true)
            {
                SetAllFalse(1);
            }
        }

        private void AmpGeneratorToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (AmpGeneratorToggle.Checked == true)
            {
                SetAllFalse(2);
            }
        }

        private void VoltGeneratorToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (VoltGeneratorToggle.Checked == true)
            {
                SetAllFalse(3);
            }
        }

        private void SetAllFalse(int num)
        {
            switch (num)
            {
                case 0:
                    CapacitorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    break;
                case 1:
                    ResistorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    break;
                case 2:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    break;
                case 3:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    break;
                case 4:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    break;
                default:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    break;
            }
        }

        private Element IsSomethingThere(Point P)
        {
            foreach (Element comp in Components)
            {
                if (comp.Coordinates.X < P.X && comp.Coordinates.X + comp.Size.Width > P.X)
                {
                    if (comp.Coordinates.X < P.X + comp.Size.Width && comp.Coordinates.X + comp.Size.Width < P.X + comp.Size.Width)
                    {
                        if (comp.Coordinates.Y < P.Y && comp.Coordinates.Y + comp.Size.Height > P.Y)
                        {
                            if (comp.Coordinates.Y < P.Y + comp.Size.Height && comp.Coordinates.Y + comp.Size.Height < P.Y + comp.Size.Height)
                            {
                                return comp;
                            }
                        }
                    }
                }
            }
            return null;
        }

        //public void DrawGrid()
        //{
        //    int i;
        //    Pen pen = new Pen(Color.Gray, 1);
        //    Bitmap bm = new Bitmap(CircuitDraw.Width, CircuitDraw.Height);
        //    using (Graphics g = Graphics.FromImage(bm))
        //    {
        //        for (i = 0; i < this.Width; i += 20)
        //        {
        //            g.DrawLine(pen, i, 0, i, this.Height);
        //            g.DrawLine(pen, 0, i, this.Width, i);
        //        }
        //    }
        //    CircuitDraw.Image = bm;
        //    CircuitDraw.Refresh();
        //}

        private void ClearGrid()
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
            }
            //DrawGrid();
        }

        private void Reset()
        {
            using(Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
                Components.Clear();
            }
            SetAllFalse(99);
            //DrawGrid();
        }
        
        private void DrawComponents(List<Element> list)
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
                if (ResistorToggle.Checked == true)
                {
                    Element element = new Element();
                    element.Coordinates = point;
                    element.DummyDraw(g);
                }
                else if(CapacitorToggle.Checked == true)
                {
                    Element element = new Element();
                    element.Type = Type.Capacitor;
                    element.Coordinates = point;
                    element.DummyDraw(g);
                }
                else if(AmpGeneratorToggle.Checked == true)
                {
                    Element element = new Element();
                    element.Type = Type.AmpGenerator;
                    element.Coordinates = point;
                    element.DummyDraw(g);
                }
                else if(VoltGeneratorToggle.Checked == true)
                {
                    Element element = new Element();
                    element.Type = Type.VoltGenerator;
                    element.Coordinates = point;
                    element.DummyDraw(g);
                }
            }
        }

        private void DrawConnections(List<Element> elements)
        {
            using(Graphics g = CircuitDraw.CreateGraphics())
            {
                foreach (Element element in elements)
                    element.DrawConnection(g);
            }
        }

        private void CircuitDraw_MouseClick(object sender, MouseEventArgs e)
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                if (IsSomethingThere(new Point(e.X, e.Y)) != null && !btnConnect.Focused && !btnCursor.Focused && !btnRotate.Focused)
                {
                    MessageBox.Show("There's already something there.");
                }
                else
                {
                    if (ResistorToggle.Checked == true)
                    {
                        Element R = new Element(Type.Resistor, $"R{ResistorCounter++}", 50, Orientation.Horizontal, Direction.None, e.Location);
                        Components.Add(R);  //Adds the component to global list
                    }
                    else if (CapacitorToggle.Checked == true)
                    {
                        Element C = new Element(Type.Capacitor, $"C{CapacitorCounter++}", 50, Orientation.Horizontal, Direction.None, e.Location);
                        Components.Add(C);
                    }
                    else if (AmpGeneratorToggle.Checked == true)
                    {
                        Element A = new Element(Type.AmpGenerator, $"J{AmpGeneratorCounter++}", 50, Orientation.Horizontal, Direction.Right, e.Location);
                        Components.Add(A);
                    }
                    else if (VoltGeneratorToggle.Checked == true)
                    {
                        Element V = new Element(Type.VoltGenerator, $"E{VoltGeneratorCounter++}", 50, Orientation.Horizontal, Direction.Right, e.Location);
                        Components.Add(V);
                    }
                    else if (btnCursor.Focused)
                    {
                        BtnCursor_Click(sender, e);
                    }
                    else if (btnConnect.Focused)
                    {
                        Connect_Click(sender, e);
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
            if(moving == true)
            {
                if(selected != null)
                {
                    selected.Coordinates = new Point(e.X, e.Y);
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            SetAllFalse(99);
            if (connectee1 == null)
            {
                if (IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position)) != null)
                {
                    connectee1 = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
                }
            }
            else if (connectee2 == null)
            {
                if (IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position)) != null)
                {
                    connectee2 = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
                    if(connectee1 != null && connectee2 != null)
                    {
                        connectee1.Connections.Add(connectee2);
                        connectee2.Connections.Add(connectee1);
                        connectee1 = null;
                        connectee2 = null;
                    }
                }
            }
        }

        private void ProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            SetAllFalse(99);
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
            SetAllFalse(99);
            selected = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
            if(selected != null)
            {
                MouseEventArgs m = (MouseEventArgs)e;
                if(m.Button == MouseButtons.Right)
                {
                    if (selected != null)
                        moving = true;
                    else
                        moving = false;
                }
                else if(m.Button == MouseButtons.Left)
                {
                    lblName.Text = selected.Name;
                    lblValue.Text = selected.Value.ToString();
                }
            }
        }
        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            ClearGrid();
            DrawComponents(Components);
            DrawConnections(Components);
            DrawShadow(CircuitDraw.PointToClient(Cursor.Position));

            Invalidate();
        }
    }
}
