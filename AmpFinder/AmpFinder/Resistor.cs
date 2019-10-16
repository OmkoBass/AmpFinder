using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmpFinder
{
    class Resistor : Element
    {
        public Resistor()
        {

        }
        public Resistor(string name, double value, Orientation orientation, Direction direction)
        {
            this.Name = name;
            this.Value = value;
            this.Orientation = orientation;
            this.Direction = direction;
        }

        internal void Draw(Graphics g, int X, int Y)    //Maybe need more arguments here
        {
            Pen pen = new Pen(Color.Black, 5);
            if (this.Orientation == Orientation.HORIZONTAL) //50x25
            {
                g.DrawRectangle(pen, X, Y, 50, 25);
            }
            else if(this.Orientation == Orientation.VERTICAL)
            {
                g.DrawRectangle(pen, X, Y, 25, 50);
            }
        }

        internal void DummyDraw(Graphics g, int X, int Y)
        {
            Pen pen = new Pen(Color.LightGray, 5);
            g.DrawRectangle(pen, X, Y, 50, 25);
        }

        public override string ToString()
        {
            return $"{this.Name}--{this.Value}\n{this.Orientation}--{this.Direction}";
        }
    }
}
