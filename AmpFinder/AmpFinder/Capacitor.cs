using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpFinder
{
    class Capacitor : Element
    {
        public Capacitor()
        {

        }
        public Capacitor(string name, double value, Orientation orientation, Direction direction)
        {
            this.Name = name;
            this.Value = value;
            this.Orientation = orientation;
            this.Direction = direction;
        }

        internal void Draw(Graphics g, int X, int Y)
        {
            if(this.Orientation == Orientation.HORIZONTAL)
            {
                Image capacitor = Image.FromFile("CapacitorHorizontal.png");    //48x48
                g.DrawImage(capacitor, X, Y);
            }
            else if(this.Orientation == Orientation.VERTICAL)
            {
                Image capacitor = Image.FromFile("CapacitorVertical.png");
                g.DrawImage(capacitor, X, Y);
            }
        }

        internal void DummyDraw(Graphics g, int X, int Y)
        {

        }

        public override string ToString()
        {
            return $"{this.Name}--{this.Value}\n{this.Orientation}--{this.Direction}";
        }
    }
}
