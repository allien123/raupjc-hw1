using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monogame_project
{
    class CollisionDetector
    {
        public static bool Overlaps(IPhysicalObject2D a, IPhysicalObject2D b)
        {
            bool vertical = a.Y < b.Y && a.Y + a.Height > b.Y || a.Y > b.Y && a.Y < b.Y + b.Height;
            bool horizontal = a.X < b.X && a.X + a.Width > b.X || a.X > b.X && a.X < b.X + b.Width;
            return vertical && horizontal;
        }
    }
}
