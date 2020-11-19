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
                Rectangle rect = new Rectangle(map.pointsSet[i].X, map.pointsSet[i].Y, settings.MINIMAP_TILE, map.settings.MINIMAP_TILE);
                graphics.DrawRectangle(settings.green_pen, rect);
                graphics.FillRectangle(settings.blue_brush, rect);
            }
        }
        public void drawing_2D_line(Player player, Graphics gr)
        {
            
            float x1 = (player.x + settings.PLAYER_RADIUS_2D);
            float y1 = (player.y + settings.PLAYER_RADIUS_2D);
            PointF p1 = new PointF(x1, y1);// первая точка
            float Xp = (float)(player.x + settings.PLAYER_RADIUS_2D + settings.LINE_WIDTH * Math.Cos((double)(player.angle * Math.PI / 180.0)));
            float Yp = (float)(player.y + settings.PLAYER_RADIUS_2D + settings.LINE_WIDTH * Math.Sin((double)(player.angle * Math.PI / 180.0)));

            PointF p2 = new PointF(Xp, Yp);// вторая точка
            gr.DrawLine(settings.green_pen, p1, p2);// рисуем линию       
            

        }
        public void drawing_2D_background(Graphics gr, Panel panel)
        {
            gr.FillRectangle(Brushes.White, 0, 0, panel.Width, panel.Height);
        }
            /*
            public void drawPointingLine(Graphics gr)
            {
                //Line

                draw.drawing_2D_map(map_2D, gr, black_pen, blue_brush);
                PointF p1 = new PointF(player.x + PLAYER_RADIUS_2D, (int)(player.y + PLAYER_RADIUS_2D));// первая точка
                float Xp = (float)(player.x + PLAYER_RADIUS_2D + LINE_WIDTH * Math.Cos((double)(player.angle * Math.PI / 180.0)));
                float Yp = (float)(player.y + PLAYER_RADIUS_2D + LINE_WIDTH * Math.Sin((double)(player.angle * Math.PI / 180.0)));

                PointF p2 = new PointF(Xp, Yp);// вторая точка
                gr.DrawLine(green_pen, p1, p2);// рисуем линию
                gr.Dispose();// освобождаем все ресурсы, связанные с отрисовкой
            }
            */
        }
}
