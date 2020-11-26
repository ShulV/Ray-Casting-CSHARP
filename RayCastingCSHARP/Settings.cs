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
        static public float ROTATE_ANGLE; //угол одного поворота
        static public int LINE_WIDTH; //длина линии-указателя игрока на 2D карте
        static public int PLAYER_SPEED; //скорость передвижения
        static public int MINIMAP_WIDTH; // ширина миникарты
        static public int MINIMAP_HEIGHT; //высота миникарты
        static public int MINIMAP_TILE;//сторона квадрата
        static public int WIDTH_BLOCKS; //кол-во квадратов карты в ширину
        static public int HEIGHT_BLOCKS; //кол-во квадратов карты в длину
        public PictureBox PB_Player; //картинка игрока на миникарте (2D)
        // RAY CASTING
        static public double FOV; //угол обзора
        static public double HALF_FOV; //половина угла обзора
        static public int NUM_RAYS; //кол-во лучей
        static public int MAX_DEPTH; //дальность прорисовки
        static public double DELTA_ANGLE; //угол между лучами
        // FOR 3D
        static public double DIST; //расстояние от игрока до стены
        static public double PROJ_COEFF; //коэффициент проекции

        static public Pen green_pen; // ручка зеленый 1
        static public Pen black_pen = new Pen(Color.Black, 1);// ручка черный 1
        static public Brush blue_brush = Brushes.Blue;// кисть синяя

        public void InitSettings(Panel minimap_panel)
        {
            //-------------------------------2D-------------------------------------
        WIDTH = 1200; //ширина панели миникарты
        HEIGHT = 800; //высота панели миникарты
        ROTATE_ANGLE = 5; //угол одного поворота
        PLAYER_SPEED = 20; //скорость передвижения
        MINIMAP_WIDTH = minimap_panel.Size.Width; // ширина миникарты
        MINIMAP_HEIGHT = minimap_panel.Size.Height; ; //высота миникарты
        WIDTH_BLOCKS = 12; //кол-во квадратов карты в ширину
        HEIGHT_BLOCKS = 8; //кол-во квадратов карты в длину
        MINIMAP_TILE = MINIMAP_HEIGHT / HEIGHT_BLOCKS; //сторона квадрата
        LINE_WIDTH = MINIMAP_WIDTH; //длина линии-указателя игрока на 2D карте
        PB_Player = new PictureBox(); //картинка игрока на миникарте (2D)
        //RAY CASTING
        FOV = 60;//угол обзора в градусах
        HALF_FOV = FOV / 2; //половина угла обзора
        NUM_RAYS = 20;//120 //кол-во лучей
        MAX_DEPTH = 50;//MINIMAP_HEIGHT; //дальность прорисовки
        DELTA_ANGLE = FOV / NUM_RAYS; //угол между лучами
        // FOR 3D
        DIST = NUM_RAYS/(2*Math.Tan(Settings.HALF_FOV)); //расстояние от игрока до стены
        PROJ_COEFF = DIST * Settings.MINIMAP_TILE; //коэффициент проекции
        }
        
    }
    
}
