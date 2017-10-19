using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace monogame_project
{
    public class LimitedVector
    {
        public enum Direction
        {
            LeftUp,LeftDown,RightUp,RightDown
        }

        public int X { get; private set; }
        public int Y { get; private set; }

        public LimitedVector(Direction direction)
        {
            if (direction == Direction.LeftUp || direction == Direction.LeftDown)
            {
                X = -1;
            }
            else
            {
                X = 1;
            }

            if (direction == Direction.LeftUp || direction == Direction.RightUp)
            {
                Y = -1;
            }
            else
            {
                Y = 1;
            }
        }

        public void reverseHorizontalDirection()
        {
            X *= -1;
        }

        public void reverseVerticalDirection()
        {
            Y *= -1;
        }

        public static Vector2 operator *(LimitedVector limitedVector, Vector2 vector)
        {
            return new Vector2(limitedVector.X*vector.X,limitedVector.Y*vector.Y);
        }

        public static Vector2 operator *(LimitedVector limitedVector, float factor)
        {
            return new Vector2(limitedVector.X *factor, limitedVector.Y * factor);
        }

    }
}
