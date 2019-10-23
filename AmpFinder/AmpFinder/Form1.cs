﻿using System;
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
        public enum Themes { Black, White }

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

        private Element IsSomethingThere(MouseEventArgs e)
        {
            Point P = e.Location;
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

        public void DrawGrid(Themes t)
        {
            int i;
            Pen pen = new Pen(Color.Gray, 1);
            switch (t)
            {
                case Themes.Black:
                    pen.Color = Color.Black;
                    break;
            }
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

        private void Reset()
        {
            using(Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
                Components.Clear();
            }
            DrawGrid(Themes.White); ;
        }

        private void ClearGrid()
        {
            using (Graphics g = CircuitDraw.CreateGraphics())
            {
                g.Clear(Color.White);
            }
            DrawGrid(Themes.White);
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

        private void CircuitDraw_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CircuitDraw.CreateGraphics();
            if (IsSomethingThere(e) != null && EditToggle.Checked == false)
            {
                MessageBox.Show("There's already something there.");
            }
            else
            {
                if (ResistorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Element R = new Element(Type.Resistor, $"R{ResistorCounter}", 50, Orientation.Horizontal, Direction.None);
                        R.Coordinates = e.Location;
                        ResistorCounter++;  //For better naming
                        Components.Add(R);  //Adds the component to global list
                    }
                }
                else if (CapacitorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Element C = new Element(Type.Capacitor, $"C{CapacitorCounter}", 50, Orientation.Horizontal, Direction.None);
                        C.Coordinates = e.Location;
                        CapacitorCounter++;
                        Components.Add(C);
                    }
                }
                else if (AmpGeneratorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Element A = new Element(Type.AmpGenerator, $"J{AmpGeneratorCounter}", 50, Orientation.Horizontal, Direction.Right);
                        A.Coordinates = e.Location;
                        AmpGeneratorCounter++;
                        Components.Add(A);
                    }
                }
                else if (VoltGeneratorToggle.Checked == true)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Element V = new Element(Type.VoltGenerator, $"E{VoltGeneratorCounter}", 50, Orientation.Horizontal, Direction.Right);
                        V.Coordinates = e.Location;
                        AmpGeneratorCounter++;
                        Components.Add(V);
                    }
                }
                else if (EditToggle.Checked == true)
                {
                    if(IsSomethingThere(e) != null)
                    {
                        if(e.Button == MouseButtons.Right)
                        {
                            Element element = IsSomethingThere(e);
                            if (element.Type == Type.AmpGenerator || element.Type == Type.VoltGenerator)
                            {
                                element.SwitchDirection();
                            }
                            else if(element.Type == Type.Resistor || element.Type == Type.Capacitor)
                            {
                                element.SwitchOrientation();
                            }
                        }
                        else if(e.Button == MouseButtons.Left)
                        {
                            Element element = IsSomethingThere(e);
                        }
                    }
                    else
                    {

                    }
                }
            }
        }

        private void NewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void DrawTimer_Tick(object sender, EventArgs e)
        {
            ClearGrid();
            DrawComponents(Components);
            DrawShadow((CircuitDraw.PointToClient(Cursor.Position)));

            Invalidate();
        }

        private void WhiteThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.White;
            CircuitDraw.BackColor = Color.White;
        }

        private void BlackThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.DarkGray;
            CircuitDraw.BackColor = Color.Black;
        }
    }
}
