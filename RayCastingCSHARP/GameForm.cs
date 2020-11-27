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
        Map map_2D;
        Drawing draw;
        Player player;
        Point playerPos;
        Graphics map_2D_panel_graphics;
        Graphics map_3D_panel_graphics;

        public GameForm()
        {
            InitializeComponent();
            Invalidate(); //перерисовка формы

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //настройки
            settings = new Settings();
            settings.InitSettings(map_2D_panel, map_3D_panel);
            //создание рисовалки
            draw = new Drawing(settings);
            //карта 2D
            map_2D = new Map(settings);
            map_2D.fillPointsSet();
            //создание игрока
            CreatePlayer();
            playerPos = new Point((int)player.x, (int)player.y);
            //панель для миникарты
            map_2D_panel.Location = new Point(0, 640);
            map_2D_panel.Size = new Size(Settings.MAP_2D_WIDTH, Settings.MAP_2D_HEIGHT);
            map_3D_panel.Location = new Point(0, 0);
            map_3D_panel.Size = new Size(Settings.WIDTH, Settings.HEIGHT);



            map_2D_panel_graphics = map_2D_panel.CreateGraphics();
            map_3D_panel_graphics = map_3D_panel.CreateGraphics();
            

        }

        public void CreatePlayer()
        {
            player = new Player((int)Settings.WIDTH/2, (int)Settings.HEIGHT/2, 0);
        }

        public void maps_refresh(Graphics gr_2D, Graphics gr_3D)
        {
            //draw.drawing_2D_background(gr_2D);
            //draw.drawing_2D_map(map_2D, gr_2D);
            //draw.drawing_2D_ray(player, gr_2D);
            draw.drawing_3D_background(gr_3D);
            draw.ray_casting(gr_2D, gr_3D, player);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                //label1.Text = Math.Ceiling(player.distance_to_wall).ToString() + "   ___     " + Settings.PLAYER_SPEED + ";";
                if (Math.Ceiling(player.distance_to_wall*1.5) > Settings.PLAYER_SPEED) {
                    player.x += (float)(Settings.PLAYER_SPEED * Math.Cos((double)(player.angle * Math.PI / 180.0)));
                    player.y += (float)(Settings.PLAYER_SPEED * Math.Sin((double)(player.angle * Math.PI / 180.0)));
                }
                
            }
            if (e.KeyCode == Keys.Left)
            {
                player.angle -= Settings.ROTATE_ANGLE;
            }
            if (e.KeyCode == Keys.Right)
            {
                player.angle += Settings.ROTATE_ANGLE;
            }
            playerPos.X = (int)player.x;
            playerPos.Y = (int)player.y;

            double cur_angle = player.angle - Settings.HALF_FOV;


            maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
            Invalidate();//перерисовка
            
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
        }
    }
}
