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
        internal Size Size { get; set; }

        public Connector()
        {

        }

        public Connector(Element from, Point coordinates)
        {
            this.From = from;
            this.Coordinates = coordinates;
            this.From.Size = new Size(25, 10);
        }

        public void Draw(Graphics g)
        {
            if (this.From.Orientation == Orientation.Horizontal)
            {
                g.DrawLine(new Pen(Brushes.Black, 2), this.From.Coordinates.X, this.From.Coordinates.Y + (this.From.Size.Height / 2), this.From.Coordinates.X - (this.From.Size.Width / 2), this.From.Coordinates.Y + (this.From.Size.Height / 2));
                g.DrawLine(new Pen(Brushes.Black, 2), this.From.Coordinates.X + this.From.Size.Width, this.From.Coordinates.Y + (this.From.Size.Height / 2), this.From.Coordinates.X + (this.From.Size.Width * 1.5f), this.From.Coordinates.Y + (this.From.Size.Height / 2));
            }
            else if(this.From.Orientation == Orientation.Vertical)
            {
                g.DrawLine(new Pen(Brushes.Black, 2), this.From.Coordinates.X + (this.From.Size.Width / 2), this.From.Coordinates.Y, this.From.Coordinates.X + (this.From.Size.Width / 2), this.From.Coordinates.Y - (this.From.Size.Height / 2));
                g.DrawLine(new Pen(Brushes.Black, 2), this.From.Coordinates.X + (this.From.Size.Width / 2), this.From.Coordinates.Y + (this.From.Size.Height), this.From.Coordinates.X + (this.From.Size.Width / 2), this.From.Coordinates.Y + (this.From.Size.Height * 1.5f));
            }
        }
    }
}
