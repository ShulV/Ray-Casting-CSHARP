using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace RayCastingCSHARP
{
    class Drawing
    {
        public Drawing()
        {

        }
        public void drawing_2D_map(Map map, Graphics graphics)
        {
            //отрисовка квадратов на 2D карте
            for (int i = 0; i < map.countPoints; i++)
            {
                Rectangle rect = new Rectangle(Map.pointsSet[i].X/Settings.SCALE_FACTOR, Map.pointsSet[i].Y / Settings.SCALE_FACTOR, Settings.MAP_TILE / Settings.SCALE_FACTOR, Settings.MAP_TILE / Settings.SCALE_FACTOR);
                Pen pen = new Pen(Color.Azure, 2f);
                graphics.DrawRectangle(pen, rect);
                graphics.FillRectangle(Brushes.Blue, rect);
            }
        }
        public void drawing_2D_ray(Player player, Graphics gr)
        {
            //начальные координаты линии
            float x1 = (float)(player.x);
            float y1 = (float)(player.y);
            PointF p1 = new PointF((float)x1/Settings.SCALE_FACTOR, (float)y1/Settings.SCALE_FACTOR);// первая точка
            //конечные координаты линии
            float Xp = (float)(player.x + Settings.LINE_WIDTH * Math.Cos((double)(player.angle * Math.PI / 180.0)));
            float Yp = (float)(player.y + Settings.LINE_WIDTH * Math.Sin((double)(player.angle * Math.PI / 180.0)));
            PointF p2 = new PointF(Xp / Settings.SCALE_FACTOR, Yp / Settings.SCALE_FACTOR);// вторая точка
            gr.DrawLine(Pens.Green, p1, p2);//рисуем линию  
            //отрисовка круга на 2D карте
            float half_side = 4f;
            RectangleF rect = new RectangleF(x1 / Settings.SCALE_FACTOR - half_side, y1 / Settings.SCALE_FACTOR - half_side, half_side * 2, half_side * 2);
            gr.DrawEllipse(Pens.Lime, rect);
            gr.FillEllipse(Brushes.Lime, rect);

        }
        public void drawing_3D_background(Graphics gr)
        {
            //закрашивание верхнего прямоугольника 3D карты цветом НЕБА
            gr.FillRectangle(Brushes.SkyBlue, 0, 0, Settings.MAP_3D_WIDTH, Settings.MAP_3D_HEIGHT/2);
            //закрашивание нижнего прямоугольника 3D карты цветом ЗЕМЛИ
            gr.FillRectangle(Brushes.SaddleBrown, 0, Settings.MAP_3D_HEIGHT / 2, Settings.MAP_3D_WIDTH, Settings.MAP_3D_HEIGHT / 2);
        }
        public void drawing_2D_background(Graphics gr)
        {
            //закрашивание 2D карты
            gr.FillRectangle(Brushes.White, 0, 0, Settings.MAP_2D_WIDTH, Settings.MAP_2D_HEIGHT);
        }
        public Point mapping(double a, double b)
        {
            //получение ближайшего слева сверху пересечения вертикалей и горизонаталей
            //от текущей позиции игрока
            int tile = Settings.MAP_TILE;
            Point point = new Point((int)(a / tile * tile), (int)(b / tile * tile));
            return point;
        }
        /*
        public void ray_casting(Graphics gr_2D, Graphics gr_3D, Player player)
        {
            PointF point_0 = new PointF((float)player.x, (float)player.y);
            double x = 0, y = 0;
            int dx = 0, dy = 0;
            double depth = 0, depth_v = 0, depth_h = 0;
            Point point_m = mapping(player.x, player.y);
            double cur_angle = player.angle - Settings.HALF_FOV;
            SolidBrush wall_brush = new SolidBrush(Color.White);
            int rgb_num = 0;
            //проход по всем лучам в цикле
            for (int ray = 0; ray < Settings.NUM_RAYS; ray++)
            {
                double sin_a = Math.Sin(cur_angle * Math.PI / 180.0);
                double cos_a = Math.Cos(cur_angle * Math.PI / 180.0);
                
                //вертикали
                if (cos_a >= 0)
                {
                    x = point_m.X + Settings.MAP_TILE;
                    dx = 1;
                }
                else
                {
                    x = point_m.X;
                    dx = -1;
                }
                for(int i=0; i<Settings.WIDTH; i = i + Settings.MAP_TILE)
                {
                    depth_v = (x - point_0.X) / cos_a;
                    y = point_0.Y + depth_v * sin_a;
                    if (Map.pointsCenterSet.Contains(new Point((int)(x + dx), (int)y)))
                    {
                        break;
                    }
                    x += dx * Settings.MAP_TILE;
                }
                //горизонтали
                if (sin_a >= 0)
                {
                    y = point_m.Y + Settings.MAP_TILE;
                    dy = 1;
                }
                else
                {
                    y = point_m.Y;
                    dy = -1;
                }
                for (int i = 0; i < Settings.HEIGHT; i = i + Settings.MAP_TILE)
                {
                    depth_h = (y - point_0.Y) / sin_a;
                    x = point_0.X + depth_h * cos_a;
                    if (Map.pointsCenterSet.Contains(new Point((int)x, (int)(y+dy))))
                    {
                        break;
                    }
                    y += dy * Settings.MAP_TILE;
                }
                //проецирование
                if (depth_v < depth_h) depth = depth_v;
                else depth = depth_h;

                //отрисовка одной прямоугольной части стены
                Rectangle rect_wall = new Rectangle();
                double proj_height = Settings.PROJ_COEFF / (int)depth;
                rect_wall.X = ray * Settings.SCALE;
                rect_wall.Y = Settings.MAP_3D_HEIGHT / 2 - (int)(proj_height / 2);
                rect_wall.Width = Settings.SCALE;
                rect_wall.Height = (int)proj_height;
                //изменение цвета относительно расстояния до стены
                rgb_num = (int)(255 / (1 + (int)depth * (int)depth * 0.00003));
                wall_brush.Color = Color.FromArgb((int)(rgb_num / 2), rgb_num, (int)(rgb_num / 3));
                //
                gr_3D.DrawRectangle(Pens.Brown, rect_wall);
                gr_3D.FillRectangle(wall_brush, rect_wall);

                cur_angle += Settings.DELTA_ANGLE;
            }
        }
        */
        
                 public void ray_casting(Graphics gr_2D, Graphics gr_3D, Player player)
        {
            PointF start_point = new PointF((float)player.x, (float)player.y);
            double cur_angle = player.angle - Settings.HALF_FOV;
            SolidBrush wall_brush = new SolidBrush(Color.White);
            int rgb_num = 0;
            //проход по всем лучам в цикле
            for (int ray=0; ray < Settings.NUM_RAYS; ray++)
            {
                double sin_a = Math.Sin(cur_angle * Math.PI / 180.0);
                double cos_a = Math.Cos(cur_angle * Math.PI / 180.0);
                //попиксельный проход по каждому лучу
                for (int depth=0; depth < Settings.MAX_DEPTH; depth++)
                {
                    //конечные координаты текущего луча
                    float end_x = (float)(player.x + depth * cos_a);
                    float end_y = (float)(player.y + depth * sin_a);
                    PointF end_point = new PointF(end_x, end_y);
                    Point end_point_int = new Point((int)(end_x / Settings.MAP_TILE) * Settings.MAP_TILE, (int)(end_y / Settings.MAP_TILE) * Settings.MAP_TILE);
                    //конечные координаты текущего луча в INT для расчета расстояния до стены
                    end_point_int.X += Settings.MAP_TILE / 2 ;
                    end_point_int.Y += Settings.MAP_TILE / 2;
                    //gr_2D.DrawLine(Pens.Red, start_point.X, start_point.Y, end_x, end_y);// рисуем линию

                    //запись расстояния до стены (спереди)
                    if (cur_angle == player.angle) {
                        player.distance_to_wall = MathHelper.vectorLength(start_point, end_point);
                        //gr_2D.DrawLine(Pens.Red, start_point.X, start_point.Y, end_x, end_y);// рисуем линию
                    }
                    

                        //отсллеживание пересечения со стеной
                        if (Map.pointsCenterSet.Contains(end_point_int))
                        {
                            //
                            //depth = (int)(depth * Math.Cos(player.angle - cur_angle));
                            //отрисовка одной прямоугольной части стены
                            Rectangle rect_wall = new Rectangle();
                            double proj_height = Settings.PROJ_COEFF / depth;
                            rect_wall.X = ray * Settings.SCALE;
                            rect_wall.Y = Settings.MAP_3D_HEIGHT / 2 - (int)(proj_height/2);
                            rect_wall.Width = Settings.SCALE;
                            rect_wall.Height = (int)proj_height;
                        //изменение цвета относительно расстояния до стены
                        rgb_num = (int)(255 / (1 + depth * depth * 0.00003));
                            wall_brush.Color = Color.FromArgb((int)(rgb_num/2), rgb_num, (int)(rgb_num / 3));
                            //
                            gr_3D.DrawRectangle(Pens.Brown, rect_wall);
                            gr_3D.FillRectangle(wall_brush, rect_wall);
                            break;
                        }
                    
                    
                }
                cur_angle += Settings.DELTA_ANGLE;
            }
        }
         
        


        public void drawing_fps(Label fps_label, double fps)
        {
            fps_label.Text = "FPS " + ((int)fps).ToString();
        }

    }
}
