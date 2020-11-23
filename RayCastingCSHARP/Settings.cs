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
        public float ROTATE_ANGLE; //угол одного поворота
        public int PLAYER_RADIUS_2D; //радиус круга игрока на 2D карте
        public int PLAYER_DIAMETR_2D; //диаметр круга игрока на 2D карте
        public int LINE_WIDTH; //длина линии-указателя игрока на 2D карте
        public int PLAYER_SPEED; //скорость передвижения
        public int MINIMAP_WIDTH; // ширина миникарты
        public int MINIMAP_HEIGHT; //высота миникарты
        public int MINIMAP_TILE;//сторона квадрата
        public int WIDTH_BLOCKS; //кол-во квадратов карты в ширину
        public int HEIGHT_BLOCKS; //кол-во квадратов карты в длину
        public PictureBox PB_Player; //картинка игрока на миникарте (2D)
        // RAY CASTING
        public double FOV; //угол обзора
        public double HALF_FOV; //половина угла обзора
        public int NUM_RAYS; //кол-во лучей
        public int MAX_DEPTH; //дальность прорисовки
        public double DELTA_ANGLE; //угол между лучами

        public Pen green_pen; // ручка зеленый 1
        public Pen black_pen = new Pen(Color.Black, 1);// ручка черный 1
        public Brush blue_brush = Brushes.Blue;// кисть синяя

        public void InitSettings(Panel minimap_panel)
        {
        //-------------------------------2D-------------------------------------
        ROTATE_ANGLE = 5; //угол одного поворота
        PLAYER_RADIUS_2D = 10; //радиус круга игрока на 2D карте
        PLAYER_DIAMETR_2D = PLAYER_RADIUS_2D * 2; //диаметр круга игрока на 2D карте
        PLAYER_SPEED = 5; //скорость передвижения
        MINIMAP_WIDTH = minimap_panel.Size.Width; // ширина миникарты
        MINIMAP_HEIGHT = minimap_panel.Size.Height; ; //высота миникарты
        WIDTH_BLOCKS = 12; //кол-во квадратов карты в ширину
        HEIGHT_BLOCKS = 8; //кол-во квадратов карты в длину
        MINIMAP_TILE = MINIMAP_HEIGHT / HEIGHT_BLOCKS; //сторона квадрата
        LINE_WIDTH = MINIMAP_WIDTH; //длина линии-указателя игрока на 2D карте
        PB_Player = new PictureBox(); //картинка игрока на миникарте (2D)
        //RAY CASTING
        FOV = Math.PI / 3;//угол обзора
        HALF_FOV = FOV / 2; //половина угла обзора
        NUM_RAYS = 60; //кол-во лучей
        MAX_DEPTH = MINIMAP_HEIGHT; //дальность прорисовки
        DELTA_ANGLE = FOV / NUM_RAYS; //угол между лучами


            green_pen = new Pen(Color.Green, 1);// ручка зеленый 1
        black_pen = new Pen(Color.Black, 1);// ручка черный 1
        blue_brush = Brushes.Blue;// кисть синяя
        }
        
    }
    
}
