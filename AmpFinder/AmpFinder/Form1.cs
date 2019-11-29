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
        }

        //private Element IsSomethingThere(Point P)
        //{
        //    foreach (Element element in Elements)
        //    {
        //        if (element.Coordinates.X < P.X && element.Coordinates.X + element.Size.Width > P.X)
        //        {
        //            if (element.Coordinates.X < P.X + element.Size.Width && element.Coordinates.X + element.Size.Width < P.X + element.Size.Width)
        //            {
        //                if (element.Coordinates.Y < P.Y && element.Coordinates.Y + element.Size.Height > P.Y)
        //                {
        //                    if (element.Coordinates.Y < P.Y + element.Size.Height && element.Coordinates.Y + element.Size.Height < P.Y + element.Size.Height)
        //                    {
        //                        return element;
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}

        private Element IsSomethingThere(Point P)
        {
            foreach (Element element in Elements)
            {
                if (P.X > element.Coordinates.X && P.X < element.Coordinates.X + element.Size.Width)
                    if (P.Y > element.Coordinates.Y && P.Y < element.Coordinates.Y + element.Size.Height)
                        return element;
                
            }
            return null;
        }

        Point CenterElement(Point e, Type type)
        {
            switch (type)
            {
                case Type.Resistor:
                    return new Point(e.X - (48 / 2), e.Y - (24 / 2));
                case Type.Capacitor:
                    return new Point(e.X - (48 / 2), e.Y - (48 / 2));
                case Type.AmpGenerator:
                    return new Point(e.X - (52 / 2), e.Y - (52 / 2));
                case Type.VoltGenerator:
                    return new Point(e.X - (52 / 2), e.Y - (52 / 2));
            }
            return e;
        }

        private int Round(int n)
        {
            int x = (n / 20) * 20;

            int y = (n + 20);

            if (n - x > n - y)
                return y;
            return x;
        }

        public void DrawGrid()
        {
            Bitmap bm = new Bitmap(CircuitDraw.Width, CircuitDraw.Height);
            using (Graphics g = Graphics.FromImage(bm))
            {
                for (int i = 0; i < this.Width; i += 20)
                {
                    g.DrawLine(new Pen(Color.Gray, 1), i, 0, i, this.Height);
                    g.DrawLine(new Pen(Color.Gray, 1), 0, i, this.Width, i);
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
                    element.Draw(g);
        }

        private void DrawShadow(Point point)
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                Element element = new Element();
                if (btnResistor.Focused == true)
                {
                    element.Coordinates = CenterElement(point, Type.Resistor);
                    element.DummyDraw(g);
                }
                else if(btnCapacitor.Focused == true)
                {
                    element.Type = Type.Capacitor;
                    element.Coordinates = CenterElement(point, Type.Capacitor);

                    element.DummyDraw(g);
                }
                else if(btnAmpGenerator.Focused == true)
                {
                    element.Type = Type.AmpGenerator;
                    element.Coordinates = CenterElement(point, Type.AmpGenerator);

                    element.DummyDraw(g);
                }
                else if(btnVoltGenerator.Focused == true)
                {
                    element.Type = Type.VoltGenerator;
                    element.Coordinates = CenterElement(point, Type.VoltGenerator);

                    element.DummyDraw(g);
                }
            }
        }

        private void CircuitDraw_MouseClick(object sender, MouseEventArgs e)
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                if (IsSomethingThere(new Point(e.X, e.Y)) != null && !btnCursor.Focused && !btnRotate.Focused && !btnConnect.Focused)
                {
                    MessageBox.Show("There's already something there.");
                }
                else
                {
                    if (btnResistor.Focused == true)
                    {
                        Element R = new Element(Type.Resistor, $"R{ResistorCounter++}", 50, Orientation.Horizontal, Direction.None, CenterElement(e.Location, Type.Resistor));
                        Elements.Add(R);  //Adds the component to global list
                    }
                    else if (btnCapacitor.Focused == true)
                    {
                        Element C = new Element(Type.Capacitor, $"C{CapacitorCounter++}", 50, Orientation.Horizontal, Direction.None, CenterElement(e.Location, Type.Capacitor));
                        Elements.Add(C);
                    }
                    else if (btnAmpGenerator.Focused == true)
                    {
                        Element A = new Element(Type.AmpGenerator, $"J{AmpGeneratorCounter++}", 50, Orientation.Horizontal, Direction.Right, CenterElement(e.Location, Type.AmpGenerator));
                        Elements.Add(A);
                    }
                    else if (btnVoltGenerator.Focused == true)
                    {
                        Point Center = new Point(e.Location.X - (52 / 2), e.Location.Y - (52 / 2));
                        Element V = new Element(Type.VoltGenerator, $"E{VoltGeneratorCounter++}", 50, Orientation.Horizontal, Direction.Right, CenterElement(e.Location, Type.VoltGenerator));
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
                    else if(btnConnect.Focused)
                    {
                        BtnConnect_Click(sender, e);
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
                        selected.Coordinates = CenterElement(e.Location, Type.Resistor);
                        break;
                    case Type.Capacitor:
                        selected.Coordinates = CenterElement(e.Location, Type.Capacitor);
                        break;
                    case Type.VoltGenerator:
                        selected.Coordinates = CenterElement(e.Location, Type.AmpGenerator);
                        break;
                    case Type.AmpGenerator:
                        selected.Coordinates = CenterElement(e.Location, Type.VoltGenerator);
                        break;
                }
            }
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            selected = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
            if(selected != null)
            {
                if (selected.Type == Type.Resistor || selected.Type == Type.Capacitor)
                    selected.SwitchOrientation();
                else
                    selected.SwitchDirection();
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
                    lblElementValue.Text = selected.Value.ToString();
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

        private void BtnChangeValue_Click(object sender, EventArgs e)
        {
            foreach(Element element in Elements)
            {
                if (element.Name == selected.Name)
                    element.Value = int.Parse(lblElementValue.Text);
            }
            lblValue.Text = lblElementValue.Text;
            lblElementValue.Text = null;
            btnCursor.Focus();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            //if the selected element is null and we click at a good element
            if (selected == null && IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position)) != null)
            {
                selected = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
            }
            else if(selected != null)
            {
                if (IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position)) != null)
                {
                    Element second = IsSomethingThere(CircuitDraw.PointToClient(Cursor.Position));
                    //TODO See the position of the element and connec it accordingly 
                    MessageBox.Show($"{selected.Name} connected to {second.Name}");
                    selected = null;
                }
            }
        }

        private void ProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
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
