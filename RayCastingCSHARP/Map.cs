using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace RayCastingCSHARP
{
    static public class Map
    {
        static public Point[] pointsSet = new Point[Settings.WIDTH_BLOCKS * Settings.HEIGHT_BLOCKS];//массив точек, являющихся верхними левым углами квадратов, из которых состоит карта
        static public Point[] pointsCenterSet = new Point[Settings.WIDTH_BLOCKS * Settings.HEIGHT_BLOCKS];//массив точек, являющихся центрами квадратов, из которых состоит карта
        static public int countPoints;//количетсво точек, являющихся верхними левым углами квадратов, из которых состоит карта
        static public int countCenterPoints;//кол-во точек, являющихся центрами квадратов, из которых состоит карта
        static public String[] worldMap = {
                "............",
                "............",
                "............",
                "............",
                "............",
                "............",
                "............",
                "............" };

        static public void ReadWorldMap(String mapNumber)
        {
            String fileName = "map" + mapNumber;
            String[] textMap = ((String)Properties.Resources.ResourceManager.GetObject(fileName)).Split('\n');
            for (int i = 0; i < textMap.Length; i++)
            {
                textMap[i] = textMap[i].Trim(new Char[] { ' ', '\n', '\r' });
            }
            worldMap = textMap;
        }
        static public void fillPointsSet()
        {
            //очиска массивов перед заполнением
            Array.Clear(pointsSet, 0, pointsSet.Length);
            Array.Clear(pointsCenterSet, 0, pointsCenterSet.Length);
            countPoints = 0;
            countCenterPoints = 0;
            for (int n = 0; n < Settings.HEIGHT_BLOCKS; n++)
            {
                String row = worldMap[n];
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
