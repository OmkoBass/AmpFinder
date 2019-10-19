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
        List<Element> Components = new List<Element>();
        int ResistorCounter = 1;
        int CapacitorCounter = 1;
        int AmpGeneratorCounter = 1;
        int VoltGeneratorCounter = 1;

        public window()
        {
            InitializeComponent();
            Reset();
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

        private void EditToggle_CheckedChanged(object sender, EventArgs e)
        {
            if(EditToggle.Checked == true)
            {
                SetAllFalse(4);
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
                    EditToggle.Checked = false;
                    break;
                case 1:
                    ResistorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    EditToggle.Checked = false;
                    break;
                case 2:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    EditToggle.Checked = false;
                    break;
                case 3:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    EditToggle.Checked = false;
                    break;
                case 4:
                    ResistorToggle.Checked = false;
                    CapacitorToggle.Checked = false;
                    AmpGeneratorToggle.Checked = false;
                    VoltGeneratorToggle.Checked = false;
                    break;
            }
        }

        public void DrawGrid()
        {
            int i;
            Pen pen = new Pen(Color.Gray, 1);
            using(Graphics g = CircuitDraw.CreateGraphics())
            {
                for (i = 0; i < this.Width; i += 20)
                {
                    g.DrawLine(pen, i, 0, i, this.Height);
                    g.DrawLine(pen, 0, i, this.Width, i);
                }
            }
        }

        private Element IsSomethingThere(MouseEventArgs e)
        {
            Point P = FixCooridnates(e.X, e.Y);
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

        private Point FixCooridnates(int X, int Y)
        {
            //if 1163, 254 => 1160 260
            X += 20 - (X % 20);
            Y += 20 - (Y % 20);
            Point P = new Point(X, Y);
            return P;
        }

        private void Reset()
        {
            using(Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
                Components.Clear();
            }
            DrawGrid();
        }

        private void CircuitDraw_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CircuitDraw.CreateGraphics();
            if (IsSomethingThere(e) != null)
            {
                MessageBox.Show("There's already something there.");
            }
            else
            {
                if (ResistorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);   //Fixes the coordinates to corespond to the grid
                        Element R = new Element(Type.Resistor, $"R{ResistorCounter}", 50, Orientation.Horizontal, Direction.None);
                        R.Coordinates = Fixed;
                        ResistorCounter++;  //For better naming
                        Components.Add(R);  //Adds the component to global list
                        R.Draw(g, Fixed.X, Fixed.Y);   //Draws it
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element R = new Element(Type.Resistor, $"R{ResistorCounter}", 50, Orientation.Vertical, Direction.None);
                        R.Coordinates = Fixed;
                        ResistorCounter++;
                        Components.Add(R);
                        R.Draw(g, Fixed.X, Fixed.Y);
                    }
                }
                else if (CapacitorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element C = new Element(Type.Capacitor, $"C{CapacitorCounter}", 50, Orientation.Horizontal, Direction.None);
                        C.Coordinates = Fixed;
                        CapacitorCounter++;
                        Components.Add(C);
                        C.Draw(g, Fixed.X, Fixed.Y);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element C = new Element(Type.Capacitor, $"C{CapacitorCounter}", 50, Orientation.Vertical, Direction.None);
                        C.Coordinates = Fixed;
                        CapacitorCounter++;
                        Components.Add(C);
                        C.Draw(g, Fixed.X, Fixed.Y);
                    }
                }
                else if (AmpGeneratorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element A = new Element(Type.AmpGenerator, $"J{AmpGeneratorCounter}", 50, Orientation.Horizontal, Direction.Up);
                        A.Coordinates = Fixed;
                        AmpGeneratorCounter++;
                        Components.Add(A);
                        A.Draw(g, Fixed.X, Fixed.Y);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element A = new Element(Type.AmpGenerator, $"J{AmpGeneratorCounter}", 50, Orientation.Vertical, Direction.Up);
                        A.Coordinates = Fixed;
                        AmpGeneratorCounter++;
                        Components.Add(A);
                        A.Draw(g, Fixed.X, Fixed.Y);
                    }
                }
                else if (VoltGeneratorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element V = new Element(Type.VoltGenerator, $"E{VoltGeneratorCounter}", 50, Orientation.Horizontal, Direction.Up);
                        V.Coordinates = Fixed;
                        AmpGeneratorCounter++;
                        Components.Add(V);
                        V.Draw(g, Fixed.X, Fixed.Y);
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                        Point Fixed = FixCooridnates(e.X, e.Y);
                        Element V = new Element(Type.VoltGenerator, $"E{VoltGeneratorCounter}", 50, Orientation.Vertical, Direction.Up);
                        V.Coordinates = Fixed;
                        VoltGeneratorCounter++;
                        Components.Add(V);
                        V.Draw(g, Fixed.X, Fixed.Y);
                    }
                }
                else if (EditToggle.Checked == true)
                {
                    if(IsSomethingThere(e) != null)
                    {

                    }
                    else
                    {
                        Element element = IsSomethingThere(e);
                        element.SwitchDirection();
                    }
                }
            }
        }

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
