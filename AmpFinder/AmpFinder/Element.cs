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
        internal Color Color { get; set; }
        internal Connector Left { get; set; }
        internal Connector Right { get; set; }
        public Element()
        {

        }

        public Element(Type type, string name, double value, Orientation orientation, Direction direction, Point coordinates)
        {
            this.Type = type;
            this.Name = name;
            this.Value = value;
            this.Orientation = orientation;
            this.Direction = direction;
            this.Coordinates = coordinates;
            this.Left = new Connector(this, this.Coordinates);
            this.Right = new Connector(this, this.Coordinates);

            switch (Type)
            {
                case Type.Resistor:
                    if (this.Orientation == Orientation.Horizontal)
                        this.Size = new Size(48, 24);
                    else
                        this.Size = new Size(48, 24);
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
                        Image resistor = Image.FromFile("ResistorHorizontal.png");
                        g.DrawImage(resistor, this.Coordinates);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        Image resistor = Image.FromFile("ResistorVertical.png");
                        g.DrawImage(resistor, this.Coordinates);
                    }
                    break;
                case Type.Capacitor:
                    if (this.Orientation == Orientation.Horizontal)
                    {
                        Image capacitor = Image.FromFile("CapacitorHorizontal.png");
                        g.DrawImage(capacitor, this.Coordinates);
                    }
                    else if (this.Orientation == Orientation.Vertical)
                    {
                        Image capacitor = Image.FromFile("CapacitorVertical.png");
                        g.DrawImage(capacitor, this.Coordinates);
                    }
                    break;
                case Type.AmpGenerator:
                    switch(this.Direction)
                    {
                        case Direction.Up:
                            Image AmpGenerator = Image.FromFile("AmpGeneratorUp.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                        case Direction.Down:
                            AmpGenerator = Image.FromFile("AmpGeneratorDown.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                        case Direction.Left:
                            AmpGenerator = Image.FromFile("AmpGeneratorLeft.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                        case Direction.Right:
                            AmpGenerator = Image.FromFile("AmpGeneratorRight.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                    }
                    break;
                case Type.VoltGenerator:
                    switch (this.Direction)
                    {
                        case Direction.Up:
                            Image AmpGenerator = Image.FromFile("VoltGeneratorUp.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                        case Direction.Down:
                            AmpGenerator = Image.FromFile("VoltGeneratorDown.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                        case Direction.Left:
                            AmpGenerator = Image.FromFile("VoltGeneratorLeft.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                        case Direction.Right:
                            AmpGenerator = Image.FromFile("VoltGeneratorRight.png");
                            g.DrawImage(AmpGenerator, this.Coordinates);
                            break;
                    }
                    break;
            }
            this.Left.Draw(g);
            this.Left.Draw(g);
        }

        public void DummyDraw(Graphics g)
        {
            switch (this.Type)
            {
                case Type.Resistor:
                    Image resistor = Image.FromFile("ResistorShadow.png");
                    g.DrawImage(resistor, this.Coordinates);
                    break;
                case Type.Capacitor:
                    Image capacitor = Image.FromFile("CapacitorHorizontalShadow.png");
                    g.DrawImage(capacitor, this.Coordinates);
                    break;
                case Type.AmpGenerator:
                    Image AmpGenerator = Image.FromFile("AmpGeneratorShadow.png");
                    g.DrawImage(AmpGenerator, this.Coordinates);
                    break;
                case Type.VoltGenerator:
                    Image VoltGenerator = Image.FromFile("VoltGeneratorShadow.png");
                    g.DrawImage(VoltGenerator, this.Coordinates);
                    break;
            }
        }
        
        internal void SwitchDirection()
        {
            switch(this.Direction)
            {
                case Direction.Down:
                    this.Direction = Direction.Left;
                    this.Orientation = Orientation.Horizontal;
                    break;
                case Direction.Left:
                    this.Direction = Direction.Up;
                    this.Orientation = Orientation.Vertical;
                    break;
                case Direction.Up:
                    this.Direction = Direction.Right;
                    this.Orientation = Orientation.Horizontal;
                    break;
                case Direction.Right:
                    this.Direction = Direction.Down;
                    this.Orientation = Orientation.Vertical;
                    break;
            }
        }
        internal void SwitchOrientation()
        {
            if (this.Orientation == Orientation.Horizontal)
            {
                this.Orientation = Orientation.Vertical;
                this.Size = new Size(this.Size.Height, this.Size.Width);
            }
            else
            {
                this.Orientation = Orientation.Horizontal;
                this.Size = new Size(this.Size.Height, this.Size.Width);
            }
        }
    }
}
