using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpFinder
{
    public class Wire
    {
        internal List<Element> Elements = new List<Element>();
        internal List<Wire> Wires = new List<Wire>();
        internal float Lenght { get; set; }
        internal Point Coordinates { get; set; }

        public Wire()
        {

        }

        public Wire(float lenght, Point coordinates)
        {
            this.Lenght = lenght;
            this.Coordinates = coordinates;
        }

        public void DrawLine(Graphics g)
        {
            g.DrawLine(new Pen(Color.Black, 2), this.Coordinates.X, this.Coordinates.Y, this.Coordinates.X + Lenght, this.Coordinates.Y);
        }
    }
}
