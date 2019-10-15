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
using QuickGraph;

namespace AmpFinder
{
    public partial class window : Form
    {
        List<object> Components = new List<object>();
        int ResistorCounter = 1;

        public window()
        {
            InitializeComponent();
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

        private Point FixCooridnates(int X, int Y)
        {
            //if 1163, 254 => 1160 260
            X += 20 - (X % 20);
            Y += 20 - (Y % 20);
            Point P = new Point(X, Y);
            return P;
        }

        private void CircuitDraw_Paint(object sender, PaintEventArgs e)
        {
            int i;
            Pen pen = new Pen(Color.Gray, 1);
            for (i = 0; i < this.Width; i += 20)
            {
                e.Graphics.DrawLine(pen, i, 0, i, this.Height);
                e.Graphics.DrawLine(pen, 0, i, this.Width, i);
            }
        }

        private void CircuitDraw_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = CircuitDraw.CreateGraphics();
            if(ResistorToggle.Checked == true)
            {
                if(e.Button == MouseButtons.Left)
                {
                    Point Fixed = FixCooridnates(e.X, e.Y);   //Fixes the coordinates to corespond to the grid
                    Resistor R = new Resistor($"R{ResistorCounter}", 50, Orientation.HORIZONTAL, Direction.NONE);
                    ResistorCounter++;  //For better naming
                    Components.Add(R);  //Adds the component to global list
                    R.Draw(g, Fixed.X, Fixed.Y);   //Draws it
                }
                else if(e.Button == MouseButtons.Right)
                {
                    Point Fixed = FixCooridnates(e.X, e.Y);
                    Resistor R = new Resistor($"R{ResistorCounter}", 50, Orientation.VERTICAL, Direction.NONE);
                    ResistorCounter++;
                    Components.Add(R);
                    R.Draw(g, Fixed.X, Fixed.Y);
                }
            }
        }
    }
}
