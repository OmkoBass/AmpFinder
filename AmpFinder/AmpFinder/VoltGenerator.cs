using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpFinder
{
    class VoltGenerator : Element
    {
        public VoltGenerator()
        {

        }
        public VoltGenerator(string name, double value, Orientation orientation, Direction direction)
        {
            this.Name = name;
            this.Value = value;
            this.Orientation = orientation;
            this.Direction = direction;
            if (this.Orientation == Orientation.HORIZONTAL)
            {
                Size s = new Size(52, 52);
                this.Size = s;
            }
            else
            {
                Size s = new Size(52, 52);
                this.Size = s;
            }
        }

        internal void Draw(Graphics g, int X, int Y)
        {
            if (this.Orientation == Orientation.HORIZONTAL)
            {
                Image VoltGenerator = Image.FromFile("VoltGeneratorHorizontal.png");    //52x52
                g.DrawImage(VoltGenerator, X, Y);
            }
            else if (this.Orientation == Orientation.VERTICAL)
            {
                Image VoltGenerator = Image.FromFile("VoltGeneratorVertical.png");
                g.DrawImage(VoltGenerator, X, Y);
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
