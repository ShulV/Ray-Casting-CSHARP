using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RayCastingCSHARP
{
    public partial class GameForm : Form
    {
        Drawing draw;
        Player player;
        Point playerPos;
        Graphics map_2D_panel_graphics;
        Graphics map_3D_panel_graphics;
        //Graphics game_form_graphics;

        DateTime _lastCheckTime = DateTime.Now; //последнее проверенное время
        long _frameCount = 0;

        public GameForm()
        {
            InitializeComponent();
            Invalidate(); //перерисовка формы

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            
            //создание рисовалки
            draw = new Drawing();
            //карта 2D
            //map_2D = new Map();
            //создание игрока
            CreatePlayer();
            playerPos = new Point((int)player.x, (int)player.y);
            //панель для 2D карты
            map_2D_panel.Location = new Point(0, Settings.MAP_3D_HEIGHT - Settings.MAP_2D_HEIGHT);
            map_2D_panel.Size = new Size(Settings.MAP_2D_WIDTH, Settings.MAP_2D_HEIGHT);
            //панель для 3D карты
            map_3D_panel.Location = new Point(0, 0);
            map_3D_panel.Size = new Size(Settings.MAP_3D_WIDTH, Settings.MAP_3D_HEIGHT);
            //графика для панелей (нужна для рисования)
            map_2D_panel_graphics = map_2D_panel.CreateGraphics();
            map_3D_panel_graphics = map_3D_panel.CreateGraphics();

            //game_form_graphics = this.CreateGraphics();
        }

        public void CreatePlayer()
        {
            player = new Player((double)Settings.MAP_TILE * 1.5, (double)Settings.MAP_TILE * 1.5, 0);
        }

        public void maps_refresh(Graphics gr_2D, Graphics gr_3D)
        {
            draw.drawing_2D_background(gr_2D);
            draw.drawing_2D_map(gr_2D);
            draw.drawing_2D_ray(player, gr_2D);
            draw.drawing_3D_background(gr_3D);
            draw.ray_casting(gr_2D, gr_3D, player);
            //draw.drawing_fps(fps_label, GetFps());
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show(
                    "Вы действительно хотите вернуться в главную форму?",
                    "Предупреждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            if (e.KeyCode == Keys.W)
            {
                
                if (Math.Ceiling(player.distance_to_wall) > Settings.PLAYER_SPEED) {
                    player.x += (float)(Settings.PLAYER_SPEED * Math.Cos((double)(player.angle * Math.PI / 180.0)));
                    player.y += (float)(Settings.PLAYER_SPEED * Math.Sin((double)(player.angle * Math.PI / 180.0)));
                    maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
                }
                else
                {
                    //если игрок оказался в стене, вернуть его на назад
                    player.x -= (float)(Settings.PLAYER_SPEED * Math.Cos((double)(player.angle * Math.PI / 180.0)));
                    player.y -= (float)(Settings.PLAYER_SPEED * Math.Sin((double)(player.angle * Math.PI / 180.0)));
                    maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
                }
                
            }
            if (e.KeyCode == Keys.Left)
            {
                player.angle -= Settings.ROTATE_ANGLE;
                maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
            }
            if (e.KeyCode == Keys.Right)
            {
                player.angle += Settings.ROTATE_ANGLE;
                maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
            }
            playerPos.X = (int)player.x;
            playerPos.Y = (int)player.y;

            double cur_angle = player.angle - Settings.HALF_FOV;

            //проверка выхода из лабиринта
            if (playerPos.X > Settings.MAP_3D_WIDTH ||
                playerPos.X < 0 ||
                playerPos.Y > Settings.MAP_3D_HEIGHT ||
                playerPos.Y < 0)
            {
                Settings.passed_levels[Settings.current_level-1] = true;
                DialogResult result = MessageBox.Show(
                    "Вы прошли " + Settings.current_level.ToString() + " уровень!",
                    "Поздравляем!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    LevelsForm levelsForm = new LevelsForm();
                    levelsForm.Show();
                    this.Hide();
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            maps_refresh(map_2D_panel_graphics, map_3D_panel_graphics);
        }
        

        
        void OnMapUpdated()
        //вызывать, когда карта обновляется
        {

            Interlocked.Increment(ref _frameCount);
        }

        
        double GetFps()
        {
            // вызывать постоянно (в цикле)
            double secondsElapsed = (DateTime.Now - _lastCheckTime).TotalSeconds;
            long count = Interlocked.Exchange(ref _frameCount, 0);
            double fps = count / secondsElapsed;
            _lastCheckTime = DateTime.Now;
            return fps;
        }
    }
}
