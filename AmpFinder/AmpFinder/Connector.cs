using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpFinder
{
    class Connector
    {
        internal Element From { get; set; }
        internal Element To { get; set; }
        internal Point Coordinates { get; set; }

        public Connector()
        {

        }

        public Connector(Element from, Point coordinates)
        {
            this.From = from;
            this.Coordinates = coordinates;
        }

        public void Draw(Graphics g)
        {
            g.DrawLine(new Pen(Brushes.Black), this.From.Coordinates.X-20, this.From.Coordinates.Y+20, this.From.Coordinates.X, this.From.Coordinates.Y+20);
            g.DrawLine(new Pen(Brushes.Black), this.From.Coordinates.X+45, this.From.Coordinates.Y+20, this.From.Coordinates.X+65, this.From.Coordinates.Y+20);
        }
    }
}
