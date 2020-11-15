using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RayCastingCSHARP
{
    public partial class GameForm : Form
    {

        Settings settings;
        Map minimap;
        Drawing draw;
        Player player;
        PictureBox PB_player;
        public GameForm()
        {
            InitializeComponent();
            Invalidate(); //перерисовка формы
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            settings.InitSettings(minimap_2D_panel);
            PB_player = new PictureBox();
            minimap = new Map(settings);
            minimap.fillPointsSet();
            CreatePlayer();
            draw = new Drawing(settings);
        }

        public void CreatePlayer()
        {
            player = new Player((int)settings.MINIMAP_WIDTH/2, (int)settings.MINIMAP_HEIGHT/2, 0);
        }

       public void minimap_2D_panel_Paint(object sender, PaintEventArgs e)
        {
            draw.Draw2DPlayer(e, player);
            Graphics gr = e.Graphics;
            //LINE
            int x1 = (int)(player.x + settings.PLAYER_RADIUS_2D);
            int y1 = (int)(player.y + settings.PLAYER_RADIUS_2D);
            Point p1 = new Point(x1, y1);// первая точка
            int Xp = (int)(player.x + settings.PLAYER_RADIUS_2D + settings.LINE_WIDTH * Math.Cos((double)(player.angle * Math.PI / 180.0)));
            int Yp = (int)(player.y + settings.PLAYER_RADIUS_2D + settings.LINE_WIDTH * Math.Sin((double)(player.angle * Math.PI / 180.0)));
            Point p2 = new Point(Xp, Yp);// вторая точка
            gr.DrawLine(settings.green_pen, p1, p2);// рисуем линию
            label1.Text = p2.X.ToString();
            //PictureBox
           
            PB_player.Location = p1;
            PB_player.Width = settings.PLAYER_DIAMETR_2D;
            PB_player.Height = settings.PLAYER_DIAMETR_2D;
            PB_player.Image = Properties.Resources.smile;
            PB_player.SizeMode = PictureBoxSizeMode.Zoom;
            

            minimap_2D_panel.Controls.Add(PB_player);
            /**/
            /*
              int width;
            int height;

            //Circle
            Graphics gr = e.Graphics;
            width = height = settings.PLAYER_DIAMETR_2D;
            gr.DrawEllipse(settings.green_pen, (int)player.x, (int)player.y, width, height);
             */

        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                player.x += (float)(settings.PLAYER_SPEED * Math.Cos((double)(player.angle * Math.PI / 180.0)));
                player.y += (float)(settings.PLAYER_SPEED * Math.Sin((double)(player.angle * Math.PI / 180.0)));
            }
            if (e.KeyCode == Keys.Left)
            {
                player.angle -= settings.ROTATE_ANGLE;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.angle += settings.ROTATE_ANGLE;
            }
            Point playerPos = new Point((int)player.x, (int)player.y);
            PB_player.Location = playerPos;
            Invalidate();//перерисовка
            
        }
    }
}
