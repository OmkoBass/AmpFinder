using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AmpFinder
{
    enum Orientation { Horizontal, Vertical }
    enum Direction { None, Up, Down }
    enum Type { Resistor, Capacitor, AmpGenerator, VoltGenerator, None }
    class Element
    {
        internal string Name { get; set; }
        internal double? Value { get; set; } //Nullable so we can have null be equal as unknown
        internal Point Coordinates { get; set; }
        internal Size Size { get; set; }
        internal Orientation Orientation { get; set; }
        internal Direction Direction { get; set; }
        internal Type Type { get; set; }

        public Element(Type type, string name, double value, Orientation orientation, Direction direction)
        {
            this.Type = type;
            this.Name = name;
            this.Value = value;
            this.Orientation = orientation;
            this.Direction = direction;
            switch(Type)
            {
                case Type.Resistor:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        Size s = new Size(50, 25);
                        this.Size = s;
                    }
                    else
                    {
                        Size s = new Size(25, 50);
                        this.Size = s;
                    }
                    break;
                case Type.Capacitor:
                    this.Size = new Size(48, 48);
                    break;
                case Type.AmpGenerator:
                    this.Size = new Size(52, 52);
                    break;
                case Type.VoltGenerator:
                    this.Size = new Size(52, 52);
                    break;
                case Type.None:
                    this.Size = new Size(0, 0);
                    break;
            }
        }

        internal void Draw(Graphics g, int X, int Y)
        {
            switch(this.Type)
            {
                case Type.Resistor:
                    Pen pen = new Pen(Color.Black, 5);
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        g.DrawRectangle(pen, X, Y, 50, 25);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        g.DrawRectangle(pen, X, Y, 25, 50);
                    }
                    break;
                case Type.Capacitor:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        Image capacitor = Image.FromFile("CapacitorHorizontal.png");    //48x48
                        g.DrawImage(capacitor, X, Y);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        Image capacitor = Image.FromFile("CapacitorVertical.png");
                        g.DrawImage(capacitor, X, Y);
                    }
                    break;
                case Type.AmpGenerator:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        Image AmpGenerator = Image.FromFile("AmpGeneratorHorizontal.png");  //52x52
                        g.DrawImage(AmpGenerator, X, Y);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        Image AmpGenerator = Image.FromFile("AmpGeneratorVertical.png");
                        g.DrawImage(AmpGenerator, X, Y);
                    }
                    break;
                case Type.VoltGenerator:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        Image VoltGenerator = Image.FromFile("VoltGeneratorHorizontal.png");    //52x52
                        g.DrawImage(VoltGenerator, X, Y);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        Image VoltGenerator = Image.FromFile("VoltGeneratorVertical.png");
                        g.DrawImage(VoltGenerator, X, Y);
                    }
                    break;
            }
        }

        internal void Delete(Graphics g, int X, int Y)
        {
            switch(this.Type)
            {

            }
        }

        internal void SwitchDirection()
        {
            if(this.Direction == Direction.Down) { this.Direction = Direction.Up; }
            else { this.Direction = Direction.Down; }
        }
    }
}
