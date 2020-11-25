using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastingCSHARP
{
    class Player
    {
        public double x;
        public double y;
        public double angle;
        public double distance_to_wall;
        public Player(double x, double y, double angle)
        {
            this.x = x;
            this.y = y;
            this.angle = angle;
            this.distance_to_wall = 100;
        }
    }
}
