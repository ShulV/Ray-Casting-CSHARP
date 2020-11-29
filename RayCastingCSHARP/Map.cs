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
        static public Point[] pointsSet = new Point[Settings.WIDTH_BLOCKS * Settings.HEIGHT_BLOCKS];//массив точек, являющихся верхними левым углами квадратов, из которых состоит карта
        static public Point[] pointsCenterSet = new Point[Settings.WIDTH_BLOCKS * Settings.HEIGHT_BLOCKS];//массив точек, являющихся центрами квадратов, из которых состоит карта
        public int countPoints;//количетсво точек, являющихся верхними левым углами квадратов, из которых состоит карта
        public int countCenterPoints;//кол-во точек, являющихся центрами квадратов, из которых состоит карта
        public String[] worldMap = {
                "WWWWWWWWWWWW",
                "W....W.....W",
                "WW..W.WWWWWW",
                "W..W.......W",
                "W........W.W",
                "WWWWW.WWWW.W",
                "W..........W",
                "WWWWWWWWWWWW" };
        public Map()
        {
        }
        
        public void fillPointsSet()
        {
            countPoints = 0;
            countCenterPoints = 0;
            for (int n = 0; n < Settings.HEIGHT_BLOCKS; n++)
            {
                String row = this.worldMap[n];
                for (int m = 0; m < Settings.WIDTH_BLOCKS; m++)
                {
                    if (row[m] == 'W')
                    {
                        //массив точек, являющихся верхними левым углами квадратов, из которых состоит карта
                        pointsSet[countPoints++] = new Point(m * Settings.MAP_TILE, n * Settings.MAP_TILE);
                        //массив точек, являющихся центрами квадратов, из которых состоит карта
                        pointsCenterSet[countCenterPoints++] = new Point(m * Settings.MAP_TILE + Settings.MAP_TILE / 2, n * Settings.MAP_TILE + Settings.MAP_TILE / 2);
                    }
                }
            }
        }
        
    }
}
