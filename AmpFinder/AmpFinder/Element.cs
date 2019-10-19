using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AmpFinder
{
    enum Orientation { HORIZONTAL, VERTICAL }
    enum Direction { NONE, UP, DOWN }

    abstract class Element
    {
        internal string Name { get; set; }
        internal double? Value { get; set; } //Nullable so we can have null be equal as unknown
        internal Point Coordinates { get; set; }
        internal Size Size { get; set; }
        internal Orientation Orientation { get; set; }
        internal Direction Direction { get; set; }

        public void SwitchDirection()
        {
            if(this.Direction == Direction.DOWN) { this.Direction = Direction.UP; }
            else { this.Direction = Direction.DOWN; }
        }
    }
}
