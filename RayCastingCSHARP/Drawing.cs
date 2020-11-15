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
        private void Draw2DPlayer(PaintEventArgs e, Player player)
        {
            //Circle
            Graphics gr = e.Graphics;
            Point playerPos = new Point((int)player.x, (int)player.y);
           
           

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
