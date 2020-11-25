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

                Rectangle rectCenter = new Rectangle(Map.pointsCenterSet[i].X, Map.pointsCenterSet[i].Y, 5, 5);
                graphics.DrawRectangle(Pens.Aqua, rectCenter);
            }
        }
        public void drawing_2D_line(Player player, Graphics gr)
        {
            
            double x1 = (player.x/* + Settings.PLAYER_RADIUS_2D*/);
            double y1 = (player.y/* + Settings.PLAYER_RADIUS_2D*/);
            PointF p1 = new PointF((float)x1, (float)y1);// первая точка
            float Xp = (float)(player.x/* + Settings.PLAYER_RADIUS_2D*/ + Settings.LINE_WIDTH * Math.Cos((double)(player.angle * Math.PI / 180.0)));
            float Yp = (float)(player.y/* + Settings.PLAYER_RADIUS_2D*/ + Settings.LINE_WIDTH * Math.Sin((double)(player.angle * Math.PI / 180.0)));

            PointF p2 = new PointF(Xp, Yp);// вторая точка
            gr.DrawLine(Settings.green_pen, p1, p2);// рисуем линию       
            

        }
        public void drawing_2D_background(Graphics gr, Panel panel)
        {
            gr.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
        }
        public void ray_casting(Graphics gr, Player player, Label label)
        {
            double cur_angle = player.angle - Settings.HALF_FOV;
            PointF start_point = new PointF((float)player.x /* + Settings.PLAYER_RADIUS_2D*/, (float)player.y /* + Settings.PLAYER_RADIUS_2D*/);
            
            for (int ray=0; ray < Settings.NUM_RAYS; ray++)
            {
                double sin_a = Math.Sin(cur_angle * Math.PI / 180.0);
                double cos_a = Math.Cos(cur_angle * Math.PI / 180.0);
                for (int depth=0; depth < Settings.MAX_DEPTH; depth++)
                {
                    float end_x = (float)(player.x + depth * cos_a);
                    float end_y = (float)(player.y + depth * sin_a);
                    Point end_point_int = new Point((int)(end_x / Settings.MINIMAP_TILE) * Settings.MINIMAP_TILE, (int)(end_y / Settings.MINIMAP_TILE) * Settings.MINIMAP_TILE);
                    end_point_int.X += Settings.MINIMAP_TILE / 2;
                    end_point_int.Y += Settings.MINIMAP_TILE / 2;
                    //end_x += Settings.PLAYER_RADIUS_2D;
                    //end_y += Settings.PLAYER_RADIUS_2D;
                    gr.DrawLine(Settings.green_pen, start_point.X, start_point.Y, end_x, end_y);// рисуем линию
                    
                    
                    label.Text = "Точка = " + end_point_int.ToString();
                    
                        if (Map.pointsCenterSet.Contains(end_point_int))
                        {

                            break;
                        }
                    
                    
                }
                cur_angle += Settings.DELTA_ANGLE;
            }
        }

    }
}
