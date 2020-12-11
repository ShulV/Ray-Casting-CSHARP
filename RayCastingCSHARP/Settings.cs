using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace RayCastingCSHARP
{
    public class Settings
    {
        //-------------------------------2D-------------------------------------
        static public int WIDTH; //ширина панели миникарты
        static public int HEIGHT; //высота панели миникарты
        static public int SCALE_FACTOR; //масштабирующий коэф (в это число раз панель 2д карты меньше панели 3д карты)
        static public float ROTATE_ANGLE; //угол одного поворота
        static public int LINE_WIDTH; //длина линии-указателя игрока на 2D карте
        static public int PLAYER_SPEED; //скорость передвижения
        static public int MAP_2D_WIDTH; // ширина миникарты
        static public int MAP_2D_HEIGHT; //высота миникарты
        static public int MAP_TILE;//сторона квадрата
        static public int WIDTH_BLOCKS; //кол-во квадратов карты в ширину
        static public int HEIGHT_BLOCKS; //кол-во квадратов карты в длину
        // RAY CASTING
        static public int MAP_3D_WIDTH; // ширина 3d карты
        static public int MAP_3D_HEIGHT; // высота 3d карты
        static public double FOV; //угол обзора
        static public double HALF_FOV; //половина угла обзора
        static public int NUM_RAYS; //кол-во лучей
        static public int MAX_DEPTH; //дальность прорисовки
        static public double DELTA_ANGLE; //угол между лучами
        // FOR 3D
        static public double DIST; //расстояние от игрока до стены (расстояние до экрана)
        static public double PROJ_COEFF; //коэффициент проекции
        static public int SCALE; //масштабирующий коэф
        // для кнопок на форме
        static public int MAP_QUANTITY; //количество карт
        static public int current_level; //текущий уровень
        static public bool[] passed_levels; //пройденные уровни
        // текст
        static public Font font = SystemFonts.DefaultFont;
        static public void InitSettings()
        {
            //-------------------------------2D-------------------------------------
            WIDTH = 1200; //ширина панели миникарты
            HEIGHT = 800; //высота панели миникарты
            SCALE_FACTOR = 5; //масштабирующий коэф (в это число раз панель 2д карты меньше панели 3д карты)
            ROTATE_ANGLE = 5; //угол одного поворота
            PLAYER_SPEED = 20; //скорость передвижения
            MAP_2D_WIDTH = 240; // ширина миникарты
            MAP_2D_HEIGHT = 160; //высота миникарты
            MAP_3D_WIDTH = 1200; // ширина 3d карты
            MAP_3D_HEIGHT = 800; // высота 3d карты
            WIDTH_BLOCKS = 12; //кол-во квадратов карты в ширину
            HEIGHT_BLOCKS = 8; //кол-во квадратов карты в длину
            MAP_TILE = HEIGHT / HEIGHT_BLOCKS; //сторона квадрата
            LINE_WIDTH = 50; //длина линии-указателя игрока на 2D карте
                             //RAY CASTING
            FOV = 60;//угол обзора в градусах
            HALF_FOV = FOV / 2; //половина угла обзора
            NUM_RAYS = 60;//120 //кол-во лучей
            MAX_DEPTH = 800;//HEIGHT; //дальность прорисовки
            DELTA_ANGLE = FOV / NUM_RAYS; //угол между лучами
                                          // FOR 3D
            DIST = NUM_RAYS / (2 * Math.Tan(Settings.HALF_FOV * Math.PI / 180.0)); //расстояние от игрока до стены (расстояние до экрана)
            PROJ_COEFF = 3 * DIST * Settings.MAP_TILE; //коэффициент проекции
            SCALE = (int)(Settings.MAP_3D_WIDTH / Settings.NUM_RAYS); //масштабирующий коэф
            MAP_QUANTITY = 5; //количество карт
            passed_levels = new bool[MAP_QUANTITY]; //пройденные уровни
            for (int i = 0; i < MAP_QUANTITY; i++) {
                passed_levels[i] = false;
            }
                
        }
        
    }
    
}
