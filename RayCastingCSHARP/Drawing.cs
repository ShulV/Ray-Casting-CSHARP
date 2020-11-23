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
        Settings settings;

        public Drawing(Settings settings)
        {
            this.settings = settings;
        }
        public void drawing_2D_map(Map map, Graphics graphics)
        {
            for (int i = 0; i < map.countPoints; i++)
            {
                Rectangle rect = new Rectangle(Map.pointsSet[i].X, Map.pointsSet[i].Y, Settings.MINIMAP_TILE, Settings.MINIMAP_TILE);
                graphics.DrawRectangle(Settings.green_pen, rect);
                graphics.FillRectangle(Settings.blue_brush, rect);
            }
        }
        public void drawing_2D_line(Player player, Graphics gr)
        {
            
            double x1 = (player.x + Settings.PLAYER_RADIUS_2D);
            double y1 = (player.y + Settings.PLAYER_RADIUS_2D);
            PointF p1 = new PointF((float)x1, (float)y1);// первая точка
            float Xp = (float)(player.x + Settings.PLAYER_RADIUS_2D + Settings.LINE_WIDTH * Math.Cos((double)(player.angle * Math.PI / 180.0)));
            float Yp = (float)(player.y + Settings.PLAYER_RADIUS_2D + Settings.LINE_WIDTH * Math.Sin((double)(player.angle * Math.PI / 180.0)));

            PointF p2 = new PointF(Xp, Yp);// вторая точка
            gr.DrawLine(Settings.green_pen, p1, p2);// рисуем линию       
            

        }
        public void drawing_2D_background(Graphics gr, Panel panel)
        {
            gr.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
        }
        public void ray_casting(Graphics gr, Player player)
        {
            double cur_angle = player.angle - Settings.HALF_FOV;
            PointF start_point = new PointF((float)player.x + Settings.PLAYER_RADIUS_2D, (float)player.y + Settings.PLAYER_RADIUS_2D);
            
            for (int ray=0; ray < Settings.NUM_RAYS; ray++)
            {
                double sin_a = Math.Sin(cur_angle * Math.PI / 180.0);
                double cos_a = Math.Cos(cur_angle * Math.PI / 180.0);
                for (int depth=0; depth < Settings.MAX_DEPTH; depth++)
                {
                    float end_x = (float)(player.x + depth * cos_a);
                    float end_y = (float)(player.y + depth * sin_a);
                    //int end_point_x_int = (int)(end_point_x / Settings.MINIMAP_TILE * Settings.MINIMAP_TILE);
                    //int end_point_y_int = (int)(end_point_y / Settings.MINIMAP_TILE * Settings.MINIMAP_TILE);
                    end_x += Settings.PLAYER_RADIUS_2D;
                    end_y += Settings.PLAYER_RADIUS_2D;
                    PointF end_point = new PointF(end_x, end_y);
                    gr.DrawLine(Settings.green_pen, start_point.X, start_point.Y, end_x, end_y);// рисуем линию
                    
                   // Point end_point_int = new Point(end_point_x_int, end_point_y_int);
                    //if (Map.pointsSet.Contains(end_point_int)) {
                     //   break;
                   // }
                }
                cur_angle += Settings.DELTA_ANGLE;
            }
        }

    }
}
