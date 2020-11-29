using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayCastingCSHARP
{
    class Player
    {
        public double x;//координата x
        public double y;//координата y
        public double angle;//угол поворота
        public double distance_to_wall;//расстояние до стены
        public Player(double x, double y, double angle)
        {
            this.x = x;
            this.y = y;
            this.angle = angle;
            this.distance_to_wall = 100;
        }
    }
}
