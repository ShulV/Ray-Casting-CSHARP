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
        Point playerPos;
        Graphics panel_graphics;

        public GameForm()
        {
            InitializeComponent();
            Invalidate(); //перерисовка формы

        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            //настройки
            settings = new Settings();
            settings.InitSettings(minimap_2D_panel);
            //создание рисовалки
            draw = new Drawing(settings);
            //карта 2D
            minimap = new Map(settings);
            minimap.fillPointsSet();
            //создание игрока
            CreatePlayer();
            playerPos = new Point((int)player.x, (int)player.y);
            //картинка 2D
            PB_player = new PictureBox();
            PB_player.Width = settings.PLAYER_DIAMETR_2D;
            PB_player.Height = settings.PLAYER_DIAMETR_2D;
            PB_player.Image = Properties.Resources.smile;
            PB_player.SizeMode = PictureBoxSizeMode.Zoom;
            PB_player.BackColor = Color.Transparent;
            PB_player.Location = playerPos;
            minimap_2D_panel.Controls.Add(PB_player);

            panel_graphics = minimap_2D_panel.CreateGraphics();
           


        }

        public void CreatePlayer()
        {
            player = new Player((int)settings.MINIMAP_WIDTH/2, (int)settings.MINIMAP_HEIGHT/2, 0);
        }

       public void minimap_2D_panel_Paint(object sender, PaintEventArgs e)
        { 

        }
        public void minimap_2D_panel_refresh(Graphics gr)
        {
            draw.drawing_2D_background(gr, minimap_2D_panel);
            draw.drawing_2D_map(minimap, gr);
            draw.drawing_2D_line(player, gr);
            
            label1.Text = settings.LINE_WIDTH.ToString();
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
            playerPos.X = (int)player.x;
            playerPos.Y = (int)player.y;
            PB_player.Location = playerPos;

            label1.Text = player.angle.ToString();

            minimap_2D_panel_refresh(panel_graphics);
            Invalidate();//перерисовка
            
        }

        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void GameForm_Shown(object sender, EventArgs e)
        {
            minimap_2D_panel_refresh(panel_graphics);
        }
    }
}
