using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monogame_project
{
    public class Ball : Sprite
    {
        public const float TopSpeed = 1f;
        private float _speed;

        public float Speed
        {
            get { return _speed; }
            set
            {
                if (value > TopSpeed)
                {
                    _speed = TopSpeed;
                }
                else
                {
                    _speed = value;
                }
            }
        }

        public float BumpSpeedIncreaseFactor { get; set; }
        public LimitedVector Direction { get; set; }
        public Ball(int size, float speed, float
            defaultBallBumpSpeedIncreaseFactor) : base(size, size)
        {
            Speed = speed ;
            BumpSpeedIncreaseFactor = defaultBallBumpSpeedIncreaseFactor ;
            Direction = new LimitedVector(LimitedVector.Direction.RightDown);
        }
    }

}
