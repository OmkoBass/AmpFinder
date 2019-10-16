using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmpFinder
{
    class AmpGenerator : Element
    {
        public AmpGenerator()
        {

        }
        public AmpGenerator(string name, double value, Orientation orientation, Direction direction)
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
                Image AmpGenerator = Image.FromFile("AmpGeneratorHorizontal.png");  //52x52
                g.DrawImage(AmpGenerator, X, Y);
            }
            else if (this.Orientation == Orientation.VERTICAL)
            {
                Image AmpGenerator = Image.FromFile("AmpGeneratorVertical.png");
                g.DrawImage(AmpGenerator, X, Y);
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
