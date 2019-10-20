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
    enum Direction { None, Up, Down, Left, Right }
    enum Type { Resistor, Capacitor, AmpGenerator, VoltGenerator, None }
    class Element
    {
        internal string Name { get; set; }
        internal double Value { get; set; }
        internal Point Coordinates { get; set; }
        internal Size Size { get; set; }
        internal Orientation Orientation { get; set; }
        internal Direction Direction { get; set; }
        internal Type Type { get; set; }

        private Pen pen = new Pen(Color.Black, 5);
        public Element()
        {

        }

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
                        Size s = new Size(60, 20);
                        this.Size = s;
                    }
                    else
                    {
                        Size s = new Size(20, 60);
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

        internal void Draw(Graphics g)
        {
            switch(this.Type)
            {
                case Type.Resistor:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        g.DrawRectangle(pen, this.Coordinates.X, this.Coordinates.Y, this.Size.Width, this.Size.Height);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        g.DrawRectangle(pen, this.Coordinates.X, this.Coordinates.Y, this.Size.Width, this.Size.Height);
                    }
                    break;
                case Type.Capacitor:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        Image capacitor = Image.FromFile("CapacitorHorizontal.png");
                        g.DrawImage(capacitor, this.Coordinates.X, this.Coordinates.Y);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        Image capacitor = Image.FromFile("CapacitorVertical.png");
                        g.DrawImage(capacitor, this.Coordinates.X, this.Coordinates.Y);
                    }
                    break;
                case Type.AmpGenerator:
                    switch(this.Direction)
                    {
                        case Direction.Up:
                            Image AmpGenerator = Image.FromFile("AmpGeneratorUp.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                        case Direction.Down:
                            AmpGenerator = Image.FromFile("AmpGeneratorDown.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                        case Direction.Left:
                            AmpGenerator = Image.FromFile("AmpGeneratorLeft.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                        case Direction.Right:
                            AmpGenerator = Image.FromFile("AmpGeneratorRight.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                    }
                    break;
                case Type.VoltGenerator:
                    switch (this.Direction)
                    {
                        case Direction.Up:
                            Image AmpGenerator = Image.FromFile("VoltGeneratorUp.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                        case Direction.Down:
                            AmpGenerator = Image.FromFile("VoltGeneratorDown.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                        case Direction.Left:
                            AmpGenerator = Image.FromFile("VoltGeneratorLeft.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                        case Direction.Right:
                            AmpGenerator = Image.FromFile("VoltGeneratorRight.png");
                            g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                            break;
                    }
                    break;
            }
        }

        public void DummyDraw(Graphics g)
        {
            switch (this.Type)
            {
                case Type.Resistor:
                    Pen pen = new Pen(Color.LightGray, 5);
                    g.DrawRectangle(pen, this.Coordinates.X, this.Coordinates.Y, 60, 20);
                    break;
                case Type.Capacitor:
                    Image capacitor = Image.FromFile("CapacitorHorizontalShadow.png");
                    g.DrawImage(capacitor, this.Coordinates.X, this.Coordinates.Y);
                    break;
                case Type.AmpGenerator:
                    Image AmpGenerator = Image.FromFile("AmpGeneratorShadow.png");
                    g.DrawImage(AmpGenerator, this.Coordinates.X, this.Coordinates.Y);
                    break;
                case Type.VoltGenerator:
                    Image VoltGenerator = Image.FromFile("VoltGeneratorShadow.png");
                    g.DrawImage(VoltGenerator, this.Coordinates.X, this.Coordinates.Y);
                    break;
            }
        }

        internal void Delete(Graphics g)
        {
            switch(this.Type)
            {

            }
        }

        internal void SwitchDirection()
        {
            switch(this.Direction)
            {
                case Direction.Down:
                    this.Direction = Direction.Left;
                    break;
                case Direction.Left:
                    this.Direction = Direction.Up;
                    break;
                case Direction.Up:
                    this.Direction = Direction.Right;
                    break;
                case Direction.Right:
                    this.Direction = Direction.Down;
                    break;
            }
        }
    }
}
