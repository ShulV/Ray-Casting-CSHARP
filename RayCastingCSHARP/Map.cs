using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RayCastingCSHARP
{
    class Map
    {
        public Settings settings;
        static public Point[] pointsSet = new Point[12 * 8];
        public int countPoints;
        public String[] worldMap = {
                "WWWWWWWWWWWW",
                "W....W.....W",
                "W.....W....W",
                "W..........W",
                "W...W......W",
                "W..........W",
                "W..........W",
                "WWWWWWWWWWWW" };
        public Map(Settings settings)
        {
            this.settings = settings;
        }
        
        public void fillPointsSet()
        {
            countPoints = 0;
            for (int n = 0; n < Settings.HEIGHT_BLOCKS; n++)
            {
                String row = this.worldMap[n];
                for (int m = 0; m < Settings.WIDTH_BLOCKS; m++)
                {
                    if (row[m] == 'W')
                    {
                        pointsSet[countPoints++] = new Point(m * Settings.MINIMAP_TILE, n * Settings.MINIMAP_TILE);
                    }
                }
            }
        }
        
    }
}
