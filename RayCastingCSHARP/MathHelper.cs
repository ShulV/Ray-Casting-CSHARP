using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RayCastingCSHARP
{
    class MathHelper
    {
        static public float vectorLength(PointF a, PointF b)
        {
            float dx = Math.Abs(a.X) - Math.Abs(b.X);
            float dy = Math.Abs(a.Y) - Math.Abs(b.Y);
            float dL = (float)Math.Sqrt(dx * dx + dy * dy);
            return dL;
        }
        static public int vectorLength(Point a, Point b)
        {
            int dx = Math.Abs(a.X) - Math.Abs(b.X);
            int dy = Math.Abs(a.Y) - Math.Abs(b.Y);
            int dL = (int)Math.Sqrt(dx * dx + dy * dy);
            return dL;
        }
    }
}
